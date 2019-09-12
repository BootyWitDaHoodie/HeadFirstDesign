using System;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class SimpleRemoteControl
    {
        private ICommand slot;

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            this.slot.Execute();
        }
    }

    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void Setcommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        //public string ToString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.Append("\n------ Remote Control ------\n");
        //    for (int i = 0; i < onCommands.Length; i++)
        //    {
        //        stringBuilder.Append($"[slot {i}] {onCommands[i].getClass().getName()}")
        //    }
        //}

    }

    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Nothing happened...");
        }
    }

    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        //#region ICommand Members
        public void Execute()
        {
            this.light.On();
        }

        //#endregion
    }

    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        //#region ICommand Members
        public void Execute()
        {
            this.garageDoor.Up();
        }
        //#endregion
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

    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door opening...");
        }

        public void Down()
        {
            Console.WriteLine("Garage door closing...");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door stops");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light off");
        }
    }
}
