using System;
using TheDuckDuck.Behaviour;
using TheDuckDuck.DuckStuff;

namespace TheDuckDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck duckduck = new RedheadDuck();
            duckduck.PerformFly();
            duckduck.PerformQuack();
            Duck duck = new RubberDuck();
            duck.PerformFly();
            duck.PerformQuack();
            duck.QuackBehaviour = new QuackOne();
            duck.PerformQuack();
        }

    }
}
