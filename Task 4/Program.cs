// See https://aka.ms/new-console-template for more information

// Namespace declaration
namespace Task_1;

// Importing required namespace
using System;

// Program class declaration
public class Program
{
    // Main method — entry point of the application
    public static void Main(string[] args)
    {
        // Creating an instance of DayFinder
        DayFinder dayFinder = new DayFinder();

        // Calling the FindDayOfWeek method
        dayFinder.FindDayOfWeek();

        // Keeping the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
