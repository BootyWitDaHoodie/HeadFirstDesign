using System;

namespace ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetChocolateBoiler();
            chocolateBoiler.Fill();
            chocolateBoiler.Drain();
        }
    }

    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoiler _chocolateBoiler;
        private static readonly object padlock = new object();

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            lock (padlock)
            {
                if (_chocolateBoiler == null)
                {
                    _chocolateBoiler = new ChocolateBoiler();
                }

                return _chocolateBoiler;
            }
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }
        /// <summary>
        /// Drainnnnn
        /// </summary>
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // bring the contents to a boil
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
