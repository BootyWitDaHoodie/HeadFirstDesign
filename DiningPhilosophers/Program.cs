using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Fork
    {
        public int Name { get; }
        public bool InUse { get; set; }
        public Philosopher WhichPhilosopher { get; set; }
        public Fork(int name)
        {
            this.Name = name;
            this.InUse = false;
            this.WhichPhilosopher = null;
        }
    }

    public class Philosopher
    {
        public int Name { get; }
        private Fork _leftFork { get; }
        private Fork _rightFork { get; }
        private string _status { get; set; } = "thinking";
        //private readonly Philosophers _allPhilosophers;
        private readonly Random _rnd;
        private readonly int _maxThinkDuration = 1000;
        private readonly int _minThinkDuration = 50;
        static readonly SemaphoreSlim AquireEatPermissionSlip = new SemaphoreSlim(2);
        private static readonly object Sync = new object();

        public Philosopher(int name, Fork leftFork, Fork rightFork, Philosopher allPhilosopher)
        {
            this.Name = name;
            this._leftFork = leftFork;
            this._rightFork = rightFork;
            //this._allPhilosophers = allPhilosopher;
            this._rnd = new Random(this.Name);
        }

        // The routine each task employs for the eating philosophers
        public void EatingHabit(CancellationToken stopDining)
        {
            // after eat permission was granted, the philosopher will wait for a duration of durationBeforeRequestEatPermission
            var durationBeforeRequestEatPermission = 20;

            for (var i = 0;; i++)
            {
                if (stopDining.IsCancellationRequested)
                {
                    Console.WriteLine($"Philosopher {this.Name} is politely being asked to stop his dining experience");
                    stopDining.ThrowIfCancellationRequested();
                }

                try
                {
                    // wait for eating permission
                    AquireEatPermissionSlip.WaitAsync().Wait();
                    Console.WriteLine($"Philosopher {this.Name} will attempt to eat. Attempt: {i}");

                    bool isOkToEat;
                    lock (Sync)
                    {
                        isOkToEat = IsForksAvailable();
                        if (isOkToEat)
                        {
                            AquireForks();
                        }

                        if (isOkToEat)
                        {
                            PhilosopherEat();
                            ReleaseForks();
                        }
                    }
                }
                finally
                {
                    AquireEatPermissionSlip.Release();
                }

                // wait for a duration of dBREP before waiting for eat permission
                Task.Delay(durationBeforeRequestEatPermission).Wait();
            }
        }

        private bool IsForksAvailable()
        {
            // note: this Sync is superfluous
            lock (Sync)
            {
                if (_leftFork.InUse)
                {
                    Console.WriteLine($"Philosopher {Name} cannot eat. Left fork is in use");
                    return false;
                }

                if (_rightFork.InUse)
                {
                    Console.WriteLine($"Philosopher {Name} cannot eat. Right fork is in use");
                    return false;
                }
            }

            return true;
        }

        private void PhilosopherEat()
        {
            var eatingDuration = _rnd.Next(_maxThinkDuration) + _minThinkDuration;

            Console.WriteLine($"Philosopher {Name} is eating.");

            Thread.Sleep(eatingDuration); // simulate eating

            Console.WriteLine($"Philosopher {Name} is thinking after eating yummy spaghetti.");
        }

        private void ReleaseForks()
        {
            lock (Sync)
            {
                _leftFork.InUse = false;
                _leftFork.WhichPhilosopher = null;
                _rightFork.InUse = false;
                _rightFork.WhichPhilosopher = null;

                _status = "thinking";
                Console.WriteLine($"Philosopher {Name} released forks: F{_leftFork.Name}, F{_rightFork.Name}");
            }
        }

        private void AquireForks()
        {
            lock (Sync)
            {
                _leftFork.InUse = true;
                _leftFork.WhichPhilosopher = this;
                _rightFork.InUse = true;
                _rightFork.WhichPhilosopher = this;

                _status = "eating";
                Console.WriteLine($"Philosopher {Name} aquired forks: F{_leftFork.Name}, F{_rightFork.Name}");
            }
        }
    }
}
