using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    interface ICommand
    {
        void Execute();
    }
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("actionperformed on receiver");
        }
    }
    class ConcreteCommand : ICommand
    {
        private Receiver receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action();
        }
    }
    class Invoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
