namespace Assignment_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Task 1------------");
            Console.WriteLine("Example 1");
            templateMethod template = new ConcreteClass1();
            template.TemplateMethod();

            Console.WriteLine("Example 2");
            templateMethod template1 = new ConcreteClass2();
            template.TemplateMethod();
            Console.WriteLine("\n");

          

            Console.WriteLine("--------------Task 3------------");
            Console.WriteLine("Example ");
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC();

            handlerA.SetSuccessor(handlerB);
            handlerB.SetSuccessor(handlerC);

            int[] requests = { 5, 12, 25 };

            foreach (var request in requests)
            {
                handlerA.HandleRequest(request);
            }
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
            Istrategy strategyA = new ConcreteStrategyA();
            Context contextA = new Context(strategyA);
            contextA.ExecuteStrategy();

            Console.WriteLine("Example 2");
            
            Istrategy strategyB = new ConcreteStrategyB();
            Context contextB = new Context(strategyB);
            contextB.ExecuteStrategy();
            Console.WriteLine("\n");

            Console.WriteLine("--------------Task 6------------");
            Console.WriteLine("Example 1");
            Receiver receiver = new Receiver();
            ConcreteCommand cmd = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(cmd);
            invoker.ExecuteCommand();
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            Receiver receiver1 = new Receiver();
            ConcreteCommand cmd1 = new ConcreteCommand(receiver1);
            Invoker invoker1 = new Invoker();
            invoker.SetCommand(cmd1);
            invoker.ExecuteCommand();

            Console.WriteLine("\n");
            Console.WriteLine("--------------Task 7------------");
            Console.WriteLine("Example 1");
            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            Console.WriteLine("\n");

            Console.WriteLine("Example 2");
            TextEditor editor = new TextEditor();
            editor.Type("First Line");
            editor.SetState(new UpperCaseState());
            editor.Type("Second Line");
            editor.SetState(new LowerCaseState());
            editor.Type("Third Line");

            Console.WriteLine("--------------Task 8------------");
            Console.WriteLine("Example ");
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());
            ConcreteVisitor visitor = new ConcreteVisitor();
            objectStructure.Accept(visitor);
            Console.WriteLine("\n");

            
            Console.WriteLine("--------------Task 9------------");
            Console.WriteLine("Example");
            Context context = new Context { Input = "5" };

            TerminalExpression terminalExpression = new TerminalExpression();
            NonterminalExpression nonterminalExpression = new NonterminalExpression();

            Client client = new Client();
            client.AddExpression(terminalExpression);
            client.AddExpression(nonterminalExpression);

            client.Interpret(context);

            Console.WriteLine("Result: " + context.Output);
            Console.WriteLine("\n");


            Console.WriteLine("--------------Task 10------------");
            Console.WriteLine("Example ");
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.AddItem("Item 1");
            aggregate.AddItem("Item 2");
            aggregate.AddItem("Item 3");

            IIterator iterator = aggregate.CreateIterator();

            Console.WriteLine("Iterating over the collection:");
            for (object item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");


            Console.WriteLine("--------------Task 11------------");
            Console.WriteLine("Example");
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.State = "State 1";
            caretaker.Memento = originator.CreateMemento();

            originator.State = "State 2";
            Console.WriteLine("Current state: " + originator.State);

            originator.RestoreMemento(caretaker.Memento);
            Console.WriteLine("Restored state: " + originator.State);
        }
    }
}
