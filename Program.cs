using System;
using System.Data;

namespace Assignment4
{
    internal class Program
    {
        public static string add(string equation)
        {
            try
            {

                string equationWithAddition = equation.Replace("+", "+");
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("expression", typeof(string), equationWithAddition);
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);


                double result = double.Parse((string)row["expression"]);
                return result.ToString();
            }
            catch (Exception)
            {
                return " Invalid equation";
            }
        }


        public static string subtract(string equation)
        {
            try
            {
                string equationWithSubtraction = equation.Replace("-", "-");
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("expression", typeof(string), equationWithSubtraction);
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);
                double result = double.Parse((string)row["expression"]);
                return result.ToString();
            }
            catch (Exception)
            {
                return " Invalid equation";
            }
        }
        public static string multiply(string equation)
        {
            try
            {
                string equationWithSubtraction = equation.Replace("-", "-");
                string equationWithAddition = equationWithSubtraction.Replace("+", "+");
                string equationWithMultiplication = equationWithAddition.Replace("x", "*").Replace("*", "*");
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("expression", typeof(string), equationWithMultiplication);
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);
                double result = double.Parse((string)row["expression"]);
                return result.ToString();
            }
            catch (Exception)
            {
                return " Invalid equation";
            }
        }
        public static string divide(string equation)
        {
            try
            {
                string equationWithSubtraction = equation.Replace("-", "-");
                string equationWithAddition = equationWithSubtraction.Replace("+", "+");
                string equationWithMultiplication = equationWithAddition.Replace("x", "*").Replace("*", "*").Replace("·", "*");
                string equationWithDivision = equationWithMultiplication.Replace("/", "/");
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("expression", typeof(string), equationWithDivision);
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);

                double result = double.Parse((string)row["expression"]);
                string resultString = result.ToString("G17");

                return resultString;
            }
            catch (Exception)
            {
                return "Invalid equation";
            }
        }
        public static string DMAS(string equation)
        {
            try
            {
                string equationWithSubtraction = equation.Replace("-", "-");
                string equationWithAddition = equationWithSubtraction.Replace("+", "+");
                string equationWithMultiplication = equationWithAddition.Replace("x", "*").Replace("*", "*").Replace("·", "*");
                string equationWithDivision = equationWithMultiplication.Replace("/", "/");


                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("expression", typeof(string), equationWithDivision);
                DataRow row = dataTable.NewRow();
                dataTable.Rows.Add(row);

                double result = double.Parse((string)row["expression"]);
                string resultString = result.ToString("G17");

                return resultString;
            }
            catch (Exception)
            {
                return "Invalid equation";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t\tCalculator \t\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nCalculator Menu:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    Console.WriteLine("5. DMAS");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter an equation: ");
                            string equation = Console.ReadLine();

                            string result = add(equation);

                            Console.WriteLine($"Result: {result}");
                            break;
                        case 2:
                            Console.WriteLine("Enter an equation: ");
                            string equ = Console.ReadLine();

                            string res = subtract(equ);

                            Console.WriteLine($"Result: {res}");
                            break;
                        case 3:
                            Console.WriteLine("Enter an equation: ");
                            string eq = Console.ReadLine();

                            string final = add(eq);

                            Console.WriteLine($"Result: {final}");
                            break; ;
                        case 4:
                            Console.WriteLine("Enter an equation: ");
                            string equat = Console.ReadLine();

                            string output = add(equat);

                            Console.WriteLine($"Result: {output}");
                            break;
                        case 5:
                            Console.WriteLine("Enter an equation: ");
                            string eq1 = Console.ReadLine();
                            equation = eq1.Replace("/", " / ").Replace("x", " x ");
                            string[] equationParts = equation.Split(' ');
                            Array.Reverse(equationParts);
                            equation = string.Join(" ", equationParts);

                            string res1 = DMAS(equation);

                            Console.WriteLine($"Result: {res1}");
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}