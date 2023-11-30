using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{// example 1
    interface Istrategy
    {
        void Execute();
    }

    class ConcreteStrategyA : Istrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy A");
        }
    }
    // example 2
    class ConcreteStrategyB : Istrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy B");
        }
    }

    class Context
    {
        private Istrategy strategy;

        public Context(Istrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
    }
    

}
