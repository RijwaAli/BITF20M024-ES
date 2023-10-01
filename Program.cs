namespace My__Ride
{
    internal class Program
    {
        private admin admn;
        private List<Ride> rides;

        public Program()
        {
            admn = new admin();
            rides = new List<Ride>();
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO MY__RIDE");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Book a Ride");
                Console.WriteLine("2. Enter as Driver");
                Console.WriteLine("3. Enter as Admin");
                Console.WriteLine("4. Exit");
                Console.Write("Press 1 to 4 to select an option: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            BookRide();
                            break;
                        case 2:
                            EnterAsDriver();
                            break;
                        case 3:
                            EnterAsAdmin();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu option.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
        private void BookRide()
        {
        }

        private void EnterAsDriver()
        {
        }

        private void EnterAsAdmin()
        {
        }

        public static void Main(string[] args)
        {
            Program menu = new Program();
            menu.ShowMainMenu();
        }
    }
}