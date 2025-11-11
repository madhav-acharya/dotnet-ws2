// See https://aka.ms/new-console-template for more information

namespace Task_1;

using System;

// Program class declaration
public class Program
{
    // Main method — entry point of the application
    public static void Main(string[] args)
    {
        // Creating an instance of the NullOperations class
        NullOperations nullOps = new NullOperations();

        // Calling the PerformNullChecks() method
        nullOps.PerformNullChecks();

        // Keeping the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
