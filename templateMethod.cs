using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    // example 1
    abstract class templateMethod
    {

        // Template method
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }

    class ConcreteClass1 : templateMethod
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClass: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClass: PrimitiveOperation2");
        }
    }
    //example 2

    class ConcreteClass2 : templateMethod
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClass: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClass: PrimitiveOperation2");
        }
    }
}