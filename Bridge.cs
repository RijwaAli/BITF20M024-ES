using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// task 6
namespace Assignment_7
{
    // Example 1
    interface IImplementation
    {
        string OperationImplementation();
    }

    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA operation";
        }
    }

    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB operation";
        }
    }

    abstract class Abstraction
    {
        protected IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public abstract string Operation();
    }

    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation implementation) : base(implementation) { }

        public override string Operation()
        {
            return $"{implementation.OperationImplementation()}";
        }
    }

    // Example 2
    interface ITheme
    {
        string GetColor();
    }

    class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Theme";
        }
    }
    class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Light Theme";
        }
    }
    abstract class WebPage
    {
        protected ITheme theme;
        public WebPage(ITheme theme)
        {
            this.theme = theme;
        }

        public abstract string GetContent();
    }
    class HomePage : WebPage
    {
        public HomePage(ITheme theme) : base(theme) { }

        public override string GetContent()
        {
            return $"Homepage with {theme.GetColor()}";
        }
    } 
}
