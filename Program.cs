using System;
using System.Collections.Generic;

namespace Assignment_3
{
    /// <summary>
    /// task 2
    /// </summary>
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> studentDB = new Dictionary<int, string>();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t\tSTUDENT DATABASE \t\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Student Database Menu:");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. View Students");
                    Console.WriteLine("3. Search Student by ID");
                    Console.WriteLine("4. Update Student Name");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                AddStudent(studentDB);
                                break;
                            case 2:
                                ViewStudents(studentDB);
                                break;
                            case 3:
                                SearchStudent(studentDB);
                                break;
                            case 4:
                                UpdateStudent(studentDB);
                                break;
                            case 5:
                                Console.WriteLine("Exit");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid choice.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static void AddStudent(Dictionary<int, string> database)
        {
            try
            {
                Console.Write("Enter Student ID: ");
                if (int.TryParse(Console.ReadLine(), out int studentID))
                {
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();

                    if (!database.ContainsKey(studentID))
                    {
                        database.Add(studentID, studentName);
                        Console.WriteLine("Student added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student with the same ID already exists.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void ViewStudents(Dictionary<int, string> database)
        {
            try
            {
                Console.WriteLine("Student Database:");
                foreach (var kvp in database)
                {
                    Console.WriteLine($"Student ID: {kvp.Key}, Name: {kvp.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void SearchStudent(Dictionary<int, string> database)
        {
            try
            {
                Console.Write("Enter Student ID to search: ");
                if (int.TryParse(Console.ReadLine(), out int studentID))
                {
                    if (database.ContainsKey(studentID))
                    {
                        Console.WriteLine($"Student ID: {studentID}, Name: {database[studentID]}");
                    }
                    else
                    {
                        Console.WriteLine("No information regarding this id found in the database.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void UpdateStudent(Dictionary<int, string> database)
        {
            try
            {
                Console.Write("Enter Student ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int studentID))
                {
                    if (database.ContainsKey(studentID))
                    {
                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        database[studentID] = newName;
                        Console.WriteLine("Updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No information regarding this id found in the database.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid Student ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
