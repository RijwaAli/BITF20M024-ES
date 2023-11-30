using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
                Console.WriteLine("ConcreteHandlerA handling request: " + request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }

    class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("ConcreteHandlerB handling request: " + request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }

    class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20)
                Console.WriteLine("ConcreteHandlerC handling request: " + request);
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
