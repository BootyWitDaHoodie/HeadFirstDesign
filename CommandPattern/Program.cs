using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
        }
    }

    public interface Command
    {
        void Execute();
    }

    public class SimpleRemoteControl
    {
        private Command slot;

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(Command command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            this.slot.Execute();
        }
    }

    public class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.On();
        }
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Shine bright");
        }

        public void Off()
        {
            Console.WriteLine("Lights off");
        }
    }
}
