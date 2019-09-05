using TheDuckDuck.Behaviour;

namespace TheDuckDuck.DuckStuff
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehaviour = new Squeak();
            FlyBehaviour = new FlyNoWay();
        }
    }
}