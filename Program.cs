using System;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_5
{
    class Program
    {
        static string connectionString = "Data Source=localhost;Initial Catalog=AssignmentFive;Integrated Security=True";

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t\tEMPLOYEE DATABASE \t\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t----------------------------------------------\t\t\t\t\t");
            Console.WriteLine("\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nEmployee Database Menu:");
                    Console.WriteLine("1. List All Employees");
                    Console.WriteLine("2. Add Employee");
                    Console.WriteLine("3. Delete Employee");
                    Console.WriteLine("4. Update Employee");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ReadAllEmployees();
                            break;
                        case 2:
                            AddEmployee();
                            break;
                        case 3:
                            DeleteEmployee();
                            break;
                        case 4:
                            UpdateEmployee();
                            break;
                        case 5:
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

        static void ReadAllEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employees";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"EmployeeId: {reader["EmployeeId"]}, FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}, Email: {reader["Email"]}, PrimaryPhoneNumber: {reader["PrimaryPhoneNumber"]}, SecondaryPhoneNumber: {reader["SecondaryPhoneNumber"]}, CreatedBy: {reader["CreatedBy"]}, CreatedOn: {reader["CreatedOn"]}, ModifiedBy: {reader["ModifiedBy"]}, ModifiedOn: {reader["ModifiedOn"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while listing employees: {ex.Message}");
            }
        }

        static void AddEmployee()
        {
            try
            {
                Console.Write("Enter FirstName of Employee: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter LastName of Employee: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Email of Employee: ");
                string email = Console.ReadLine();
                Console.Write("Enter PrimaryPhoneNumber of Employee: ");
                string phoneNo1 = Console.ReadLine();
                Console.Write("Enter SecondaryPhoneNumber (optional, press enter to skip) of Employee: ");
                string phoneNo2 = Console.ReadLine();
                Console.Write("Enter CreatedBy: ");
                string createdBy = Console.ReadLine();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Employees (FirstName, LastName, Email, PrimaryPhoneNumber, SecondaryPhoneNumber, CreatedBy, CreatedOn) " +
                                   "VALUES (@FirstName, @LastName, @Email, @PrimaryPhoneNumber, @SecondaryPhoneNumber, @CreatedBy, @CreatedOn)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PrimaryPhoneNumber", phoneNo1);
                    command.Parameters.AddWithValue("@SecondaryPhoneNumber", string.IsNullOrEmpty(phoneNo2) ? DBNull.Value : (object)phoneNo2);
                    command.Parameters.AddWithValue("@CreatedBy", createdBy);
                    command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add employee.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding an employee: {ex.Message}");
            }
        }

        static void DeleteEmployee()
        {
            try
            {
                Console.Write("Enter Employee ID to delete: ");
                int employeeID = Convert.ToInt32(Console.ReadLine());

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Employee deleted successfully.");
                    else
                        Console.WriteLine("Employee not found or delete failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting an employee: {ex.Message}");
            }
        }

        static void UpdateEmployee()
        {
            try
            {
                Console.Write("Enter Employee ID to update: ");
                int EmployeeID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter FirstName: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter LastName: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter PrimaryPhoneNumber: ");
                string primaryPhoneNumber = Console.ReadLine();
                Console.Write("Enter SecondaryPhoneNumber (optional, press enter to skip): ");
                string secondaryPhoneNumber = Console.ReadLine();
                Console.Write("Enter ModifiedBy: ");
                string modifiedBy = Console.ReadLine();
                DateTime modifiedOn = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PrimaryPhoneNumber = @PrimaryPhoneNumber, SecondaryPhoneNumber = @SecondaryPhoneNumber, ModifiedBy = @ModifiedBy, ModifiedOn = @ModifiedOn WHERE EmployeeId = @EmployeeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", EmployeeID);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PrimaryPhoneNumber", primaryPhoneNumber);
                    command.Parameters.AddWithValue("@SecondaryPhoneNumber", string.IsNullOrEmpty(secondaryPhoneNumber) ? DBNull.Value : (object)secondaryPhoneNumber);
                    command.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
                    command.Parameters.AddWithValue("@ModifiedOn", modifiedOn);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating an employee: {ex.Message}");
            }
        }
    }
}
