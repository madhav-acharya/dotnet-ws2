// See https://aka.ms/new-console-template for more information

using System;

namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string? input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"You entered number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            try
            {
                Console.Write("\nEnter your password: ");
                string? password = Console.ReadLine();
                if (password == null || password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }
                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
