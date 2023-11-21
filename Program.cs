using Assignment6;
using static assignment_6.abstract_factory;
using static assignment_6.abstract_factory1;

namespace assignment_6
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\nExample 1");
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();
            Console.WriteLine(instance1 == instance2);

            Console.WriteLine("\n\nExample 2");
            Singleton2 instance3 = Singleton2.GetInstance();
            Singleton2 instance4 = Singleton2.GetInstance();

            Console.WriteLine(instance3 == instance4);

            //////// task 2  ////////////////////

            // Example 1
            Console.WriteLine("\n\nExample 1");
            Factory factory2 = new Factory();
            IProduct productA = factory2.CreateProduct("A");
            IProduct productB = factory2.CreateProduct("B");

            productA.Create();
            productB.Create();

            // Example 2
            Console.WriteLine("\n\nExample 2");
            Creator creatorA = new CreatorA();
            IProduct1 productA1 = creatorA.FactoryMethod();
            productA1.Create();

            Creator creatorB = new CreatorB();
            IProduct1 productB1 = creatorB.FactoryMethod();
            productB1.Create();

            ////task 3////
            Console.WriteLine("\n\nExample 1");
            IGUIFactory windowsFactory = new WindowsFactory();
            IGUIFactory macOSFactory = new MacOSFactory();

            // Create products using the factories
            IButton windowsButton = windowsFactory.CreateButton();
            ICheckbox windowsCheckbox = windowsFactory.CreateCheckbox();

            IButton macOSButton = macOSFactory.CreateButton();
            ICheckbox macOSCheckbox = macOSFactory.CreateCheckbox();

            // Display products
            windowsButton.Display();
            windowsCheckbox.Display();

            macOSButton.Display();
            macOSCheckbox.Display();


            Console.WriteLine("\n\nExample 2");
            IGUIFactory1 windowsFactory1 = new WindowsFactory1();
            IGUIFactory1 macOSFactory1 = new MacOSFactory1();

            // Create products using the factories
            IButton1 windowsButton1 = windowsFactory1.CreateButton();
            ICheckbox1 windowsCheckbox1 = windowsFactory1.CreateCheckbox();

            IButton1 macOSButton1 = macOSFactory1.CreateButton();
            ICheckbox1 macOSCheckbox1 = macOSFactory1.CreateCheckbox();

            // display products
            windowsButton1.Display();
            windowsCheckbox1.Display();

            macOSButton1.Display();
            macOSCheckbox1.Display();


            //task 4

            Console.WriteLine("\n\nExample 1");
            IBuilder builder = new Builder();
            Director director = new Director();

            director.Construct(builder);

            Product product = builder.GetResult();
            product.Show();

            Console.WriteLine("\n\nExample 2");

            IHtmlBuilder1 builder1 = new BasicHtmlBuilder();
            

            director.Construct(builder);

            HtmlDocument document = builder1.GetResult();
            document.Show();


            ConcretePrototype prototype = new ConcretePrototype(1);
            ConcretePrototype clonedObject = (ConcretePrototype)prototype.Clone();

            Console.WriteLine($"Original Object: {prototype.Id}");
            Console.WriteLine($"Cloned Object: {clonedObject.Id}");

            ComplexObject originalObject = new ComplexObject(1, new List<string> { "A", "B", "C" });
            ComplexObject clonedObject = originalObject.DeepClone();

            Console.WriteLine($"Original Object: {originalObject.Id}, Data: {string.Join(", ", originalObject.Data)}");
            Console.WriteLine($"Cloned Object: {clonedObject.Id}, Data: {string.Join(", ", clonedObject.Data)}");



        }
    }
}
