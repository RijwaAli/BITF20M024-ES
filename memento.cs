using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    
    class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                Console.WriteLine("Setting state to: " + value);
                state = value;
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Creating Memento");
            return new Memento(state);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("Restoring state from Memento");
            state = memento.State;
        }
    }

   
    class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }

  
    class Caretaker
    {
        public Memento Memento { get; set; }
    }

}
