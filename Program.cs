namespace Assignment_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Task 1------------");
            Console.WriteLine("Example 1");
            Adaptee adaptee = new Adaptee();
            Adapter adapter = new Adapter(adaptee);
            Console.WriteLine(adapter.Request());
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            ITarget targetAdapter = new Adapter2();
            Console.WriteLine(targetAdapter.Request());
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 2------------");
            Console.WriteLine("Example 1");
            Leaf leaf = new Leaf();
            Composite composite = new Composite();
            composite.Add(new Leaf());
            composite.Add(new Leaf());
            Console.WriteLine(composite.Operation());
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            Circle circle = new Circle();
            Square square = new Square();
            Picture picture = new Picture();
            picture.Add(circle);
            picture.Add(square);
            Console.WriteLine(picture.Draw());
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 3------------");
            Console.WriteLine("Example 1");
            IImage image = new VirtualProxyImage("nature.jpg");
            Console.WriteLine(image.GetDisplay());

            Console.WriteLine("\n");
            Console.WriteLine("Example 2");
            IAccount account = new SecureAccountProxy("secret");
            account.Withdraw(200);
            account.Withdraw(800);
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 4------------");
            Console.WriteLine("Example 1");
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            IFlyweight flyweight = flyweightFactory.GetFlyweight("key");
            Console.WriteLine(flyweight.Operation("extrinsic_state"));

            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            FlyweightFactory1 fwf = new FlyweightFactory1();
            ISharedData sharedData1 = fwf.GetSharedData("A");
            sharedData1.Display(1, 2);
            ISharedData sharedData2 = fwf.GetSharedData("B");
            sharedData2.Display(3, 4);
            ISharedData sharedData3 = fwf.GetSharedData("A"); // Reusing existing flyweight
            sharedData3.Display(5, 6);
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 5------------");
            Console.WriteLine("Example 1");
            Facade facade = new Facade();
            Console.WriteLine(facade.Operation());
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            ComputerFacade computerFacade = new ComputerFacade();
            Console.WriteLine(computerFacade.Start());
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 6------------");
            Console.WriteLine("Example 1");
            IImplementation implementationA = new ConcreteImplementationA();
            Abstraction abstraction = new RefinedAbstraction(implementationA);
            Console.WriteLine(abstraction.Operation());
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            ITheme darkTheme = new DarkTheme();
            WebPage homePage = new HomePage(darkTheme);
            Console.WriteLine(homePage.GetContent());

            Console.WriteLine("\n");
            Console.WriteLine("--------------Task 7------------");
            Console.WriteLine("Example 1");
            IText plainText = new PlainText("Hello, world!");
            Console.WriteLine($"Formatted Text: {plainText.Format()}");
            IText boldText = new BoldTextDecorator(plainText);
            Console.WriteLine($"Formatted Text: {boldText.Format()}");
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            IText plainText1 = new PlainText("Hello, world!");
            Console.WriteLine($"Formatted Text: {plainText1.Format()}");
            IText boldText1 = new BoldTextDecorator(plainText1);
            Console.WriteLine($"Formatted Text: {boldText1.Format()}");
        }
    }
}
