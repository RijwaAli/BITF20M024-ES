using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////task 1
namespace Assignment_7
{
    // Example 1
    class Adaptee
    {
        public string SpecificRequest()
        {
            return "Specific request";
        }
    }

    class Adapter
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string Request()
        {
            return $"Adapter: {adaptee.SpecificRequest()}";
        }
    }

    // Example 2
    interface ITarget
    {
        string Request();
    }

    class Target : ITarget
    {
        public string Request()
        {
            return "Requested target";
        }
    }

    class Adapter2 : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public string Request()
        {
            return $"Adapter: {adaptee.SpecificRequest()}";
        }
    }

}
