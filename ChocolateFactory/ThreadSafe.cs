using System.Threading;

namespace ChocolateFactory
{
    public class ThreadSafeOne
    {
        private static readonly ThreadSafeOne UniqueInstance = new ThreadSafeOne(); // guaranteed to be thread safe

        /// <summary>
        /// An eagerly created instance
        /// </summary>
        private ThreadSafeOne()
        {
        }

        public static ThreadSafeOne GetInstance()
        {
            return UniqueInstance;
        }
    }

    public class ThreadSafeTwo
    {
        private static ThreadSafeTwo _uniqueInstance;
        private static readonly object Sync = new object();

        /// <summary>
        /// "Double-checked locking" to reduce the use of synchronization in GetInstance()
        /// With this, we first check to see if an instance is created, and if not, THEN we synchronize
        /// </summary>
        private ThreadSafeTwo()
        {
        }

        public static ThreadSafeTwo GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (Sync)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new ThreadSafeTwo();
                    }
                }
            }

            return _uniqueInstance;
        }
    }
}