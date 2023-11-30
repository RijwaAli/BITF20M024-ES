using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
    // example 1
    // ConcreteElementA
    class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }
    // ConcreteElementB
    class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }

   
    interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA elementA);
        void VisitConcreteElementB(ConcreteElementB elementB);
    }

    class ConcreteVisitor : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("Visitor is processing ConcreteElementA");
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("Visitor is processing ConcreteElementB");
        }
    }

    class ObjectStructure
    {
        private List<IElement> elements = new List<IElement>();

        public void Attach(IElement element)
        {
            elements.Add(element);
        }

        public void Detach(IElement element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
