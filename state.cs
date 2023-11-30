using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    interface IState
    {
        void Handle(Context context);
    }

    // ConcreteStateA
    class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine(" State A");
            context.State = new ConcreteStateB();
        }
    }

    // ConcreteStateB
    class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B");
            context.State = new ConcreteStateA();
        }
    }

    // Context
    class Context
    {
        public IState State { get; set; }

        public Context(IState state)
        {
            State = state;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
    // example 2
    interface IWritingState
    {
        void Write(string words);
    }

    class UpperCaseState : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());
        }
    }

    class LowerCaseState : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }

    class DefaultCaseState : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }

    class TextEditor
    {
        private IWritingState currentState;

        public TextEditor()
        {
            currentState = new DefaultCaseState();
        }

        public void SetState(IWritingState state)
        {
            currentState = state;
        }

        public void Type(string words)
        {
            currentState.Write(words);
        }
    }
}
