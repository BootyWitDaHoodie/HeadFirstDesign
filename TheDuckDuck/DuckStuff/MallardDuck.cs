using System;
using TheDuckDuck.Behaviour;

namespace TheDuckDuck.DuckStuff
{
    internal class MallardDuck : Duck
    {

        public MallardDuck()
        {
            QuackBehaviour = new QuackOne();
        }

        public void Display()
        {
            Console.WriteLine("Mallard duck");
        }

    }
}