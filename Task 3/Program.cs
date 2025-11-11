// See https://aka.ms/new-console-template for more information

namespace Task_1;

using System;

// Program class declaration
public class Program
{
    // Main method — entry point of the application
    public static void Main(string[] args)
    {
        // Asking the user to input their age
        Console.Write("Enter your age: ");

        // Reading user input and converting it to integer
        int age = Convert.ToInt32(Console.ReadLine());

        // Checking if age is less than 13
        if (age < 13)
        {
            Console.WriteLine("You are a Child.");
        }
        // Checking if age is between 13 and 19
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a Teenager.");
        }
        // Checking if age is equal or greater than 20
        else if (age >= 20)
        {
            Console.WriteLine("You are an Adult.");
        }

        // Keeping the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
