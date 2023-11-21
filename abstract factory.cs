using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// task 3 example 1
namespace assignment_6
{
   public class abstract_factory
   {
        // Abstract Products
        public interface IButton
        {
            void Display();
        }

        public interface ICheckbox
        {
            void Display();
        }

        public class WindowsButton : IButton
        {
            public void Display()
            {
                Console.WriteLine(" Display Windows Button.");
            }
        }
        public class WindowsCheckbox : ICheckbox
        {
            public void Display()
            {
                Console.WriteLine(" Display Windows Checkbox.");
            }
        }

        // Concrete Products for macOS
        public class MacOSButton : IButton
        {
            public void Display()
            {
                Console.WriteLine(" Display macOS Button.");
            }
        }

        public class MacOSCheckbox : ICheckbox
        {
            public void Display()
            {
                Console.WriteLine(" Display macOS Checkbox.");
            }
        }

        // Abstract Factory
        public interface IGUIFactory
        {
            IButton CreateButton();
            ICheckbox CreateCheckbox();
        }

        // Concrete Factories
        public class WindowsFactory : IGUIFactory
        {
            public IButton CreateButton()
            {
                return new WindowsButton();
            }

            public ICheckbox CreateCheckbox()
            {
                return new WindowsCheckbox();
            }
        }

        public class MacOSFactory : IGUIFactory
        {
            public IButton CreateButton()
            {
                return new MacOSButton();
            }

            public ICheckbox CreateCheckbox()
            {
                return new MacOSCheckbox();
            }
        }

        
    }
    /// example 2

    public class abstract_factory1
    {
        // Abstract Products
        public interface IButton1
        {
            void Display();
        }

        public interface ICheckbox1
        {
            void Display();
        }

        public class WindowsButton1 : IButton1
        {
            public void Display()
            {
                Console.WriteLine(" Display Windows Button1.");
            }
        }
        public class WindowsCheckbox : ICheckbox1
        {
            public void Display()
            {
                Console.WriteLine(" Display Windows Checkbox1.");
            }
        }

        // Concrete Products for macOS
        public class MacOSButton1 : IButton1
        {
            public void Display()
            {
                Console.WriteLine(" Display macOS Button1.");
            }
        }

        public class MacOSCheckbox1 : ICheckbox1
        {
            public void Display()
            {
                Console.WriteLine(" Display macOS Checkbox1.");
            }
        }

        // Abstract Factory
        public interface IGUIFactory1
        {
            IButton1 CreateButton();
            ICheckbox1 CreateCheckbox();
        }

        // Concrete Factories
        public class WindowsFactory1 : IGUIFactory1
        {
            public IButton1 CreateButton()
            {
                return new WindowsButton1();
            }

            public ICheckbox1 CreateCheckbox()
            {
                return new WindowsCheckbox();
            }
        }

        public class MacOSFactory1 : IGUIFactory1
        {
            public IButton1 CreateButton()
            {
                return new MacOSButton1();
            }

            public ICheckbox1 CreateCheckbox()
            {
                return new MacOSCheckbox1();
            }
        }


    }
}
