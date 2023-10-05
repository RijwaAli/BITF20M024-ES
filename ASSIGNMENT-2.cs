using System;
using System.Collections.Generic;

class Program
{
    static void ConcatenateNames()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);
    }

    static void ExtractLastFiveCharacters()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string lastFiveCharacters = sentence.Substring(Math.Max(0, sentence.Length - 5));
        Console.WriteLine("Last Five Characters: " + lastFiveCharacters);
    }

    static void DisplayTemperature()
    {
        Console.Write("Enter the temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your city: ");
        string city = Console.ReadLine();

        Console.WriteLine($"The temperature in {city} is {temperature} degrees Celsius.");
    }

    static void InitializeNumbersArray()
    {
        int[] values = { 1, 2, 3, 4, 5 };

        foreach (int value in values)
        {
            Console.WriteLine(value);
        }
    }

    static void IterateFruitsWithForLoop()
    {
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Fig" };

        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }
    }

    static void IterateColorsWithForeachLoop()
    {
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange" };

        foreach (string color in colors)
        {
            Console.WriteLine(color + ", ");
        }
    }

    static void CalculateSumOfScores()
    {
        int[] scores = { 85, 92, 78, 95, 64, 70, 80, 88, 90, 75 };
        int sum = 0;
        int i = 0;

        do
        {
            sum += scores[i];
            i++;
        } while (i < scores.Length);

        Console.WriteLine("Sum of scores: " + sum);
    }

    static void FindMaxValueInArray()
    {
        int[] values = { 15, 7, 9, 22, 12, 5, 18, 20 };
        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        Console.WriteLine("Maximum value: " + max);
    }

    static void ReverseArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers);

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static void BoxingUnboxing()
    {
        int x = 42;
        object boxedX = x;
        int y = (int)boxedX;

        Console.WriteLine("Unboxed value: " + y);
    }

    static void BoxingUnboxingDouble()
    {
        double doubleValue = 3.14159;
        object boxedDouble = doubleValue;
        double unboxedValue = (double)boxedDouble;

        Console.WriteLine("Unboxed value: " + unboxedValue);
    }

    static void DynamicVariablesDemo()
    {
        dynamic myVariable = 42;
        Console.WriteLine("Type: " + myVariable.GetType() + ", Value: " + myVariable);

        myVariable = "Hello, Dynamic!";
        Console.WriteLine("Type: " + myVariable.GetType() + ", Value: " + myVariable);
    }

    static void DynamicVariablesDifferentTypesDemo()
    {
        dynamic myVariable2 = 42;
        Console.WriteLine("Type: " + myVariable2.GetType() + ", Value: " + myVariable2);

        myVariable2 = 3.14;
        Console.WriteLine("Type: " + myVariable2.GetType() + ", Value: " + myVariable2);

        myVariable2 = DateTime.Now;
        Console.WriteLine("Type: " + myVariable2.GetType() + ", Value: " + myVariable2);

        myVariable2 = "Hello, Dynamic!";
        Console.WriteLine("Type: " + myVariable2.GetType() + ", Value: " + myVariable2);
    }

    static void Main()
    {
        ConcatenateNames();
        ExtractLastFiveCharacters();
        DisplayTemperature();
        InitializeNumbersArray();
        IterateFruitsWithForLoop();
        IterateColorsWithForeachLoop();
        CalculateSumOfScores();
        FindMaxValueInArray();
        ReverseArray();
        BoxingUnboxing();
        BoxingUnboxingDouble();
        DynamicVariablesDemo();
        DynamicVariablesDifferentTypesDemo();
    }
}

 }