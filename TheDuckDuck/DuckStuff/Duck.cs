using TheDuckDuck.Behaviour;

namespace TheDuckDuck.DuckStuff
{
    public class Duck
    {
        public FlyBehaviour FlyBehaviour { get; set; }
        public QuackBehaviour QuackBehaviour { get; set; }

        public void Display()
        {
        }

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }
    }
}