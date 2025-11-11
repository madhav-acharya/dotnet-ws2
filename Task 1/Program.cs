// See https://aka.ms/new-console-template for more information

namespace Task_1;
using System;

// Program class declaration
public class Program
{
    // Main method — entry point of the application
    public static void Main(string[] args)
    {
        // Creating an instance of the Operators class
        Operators ops = new Operators();

        // Calling the Add method
        ops.Add(10, 5);

        // Calling the Subtract method
        ops.Subtract(10, 5);

        // Calling the Multiply method
        ops.Multiply(10, 5);

        // Calling the Divide method
        ops.Divide(10, 5);

        // Calling the OddEvenFinder method with an even number
        ops.OddEvenFinder(10);

        // Calling the OddEvenFinder method with an odd number
        ops.OddEvenFinder(7);

        // Keeping the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
