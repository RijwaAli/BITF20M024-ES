using System;
using System.Collections.Generic;


namespace Assignment_3
{
    internal class task1
    {
        static void Main()
        {
            Greet(); // Should display: "Hello, World!"
            Greet("Assalam-o-alaikum", "Rijwa"); 

            // calculating area
            double area1 = CalculateArea(); 
            double area2 = CalculateArea(4.5);
            double area3 = CalculateArea(3.0, 5.0); 

            Console.WriteLine($"Area 1: {area1}");
            Console.WriteLine($"Area 2: {area2}");
            Console.WriteLine($"Area 3: {area3}");

            // Test the AddNumbers methods
            int sum1 = AddNumbers(2, 3); 
            int sum2 = AddNumbers(1, 2, 3); 

            Console.WriteLine($"Sum 1: {sum1}");
            Console.WriteLine($"Sum 2: {sum2}");

            // Test the Book class
            Book book1 = new Book("Enterprise System"); // Author defaults to "Unknown"
            Book book2 = new Book("Programing Fundamentals", "Tonny Gaddis");

            Console.WriteLine($"Book 1: {book1.Title}, Author: {book1.Author}");
            Console.WriteLine($"Book 2: {book2.Title}, Author: {book2.Author}");
        }

        // Greet method with optional parameters
        static void Greet(string greeting = "Hello", string name = "World")
        {
            Console.WriteLine($"{greeting}, {name}!");
        }

        // CalculateArea method for rectangle area calculation
        static double CalculateArea(double length = 1.0, double width = 1.0)
        {
            return length * width;
        }

        // AddNumbers method with optional third parameter
        static int AddNumbers(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }
    }

    class Book
    {
        public string Title { get; }
        public string Author { get; }

        // Constructor with optional author parameter
        public Book(string title, string author = "Unknown")
        {
            Title = title;
            Author = author;
        }
    }
}
