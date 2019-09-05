using TheDuckDuck.Behaviour;

namespace TheDuckDuck.DuckStuff
{
    public class RedheadDuck : Duck
    {

        public RedheadDuck()
        {
            QuackBehaviour = new QuackOne();
            FlyBehaviour = new FlyWithWings();
        }

    }
}