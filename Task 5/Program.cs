// See https://aka.ms/new-console-template for more information

namespace Task_1;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer N to compute sum from 1 to N: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int N) && N >= 1)
        {
            int sumFor = 0;
            for (int i = 1; i <= N; i++)
            {
                sumFor += i;
            }
            Console.WriteLine($"Sum from 1 to {N} = {sumFor}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        Console.WriteLine("\nPrint numbers from 1 to 20 (skip multiples of 4, stop at 15):");
        int num = 1;
        while (num <= 20)
        {
            // Stop when number reaches 15
            if (num == 15)
            {
                Console.WriteLine("Reached 15 — stopping the loop.");
                break;
            }

            // Skip multiples of 4
            if (num % 4 == 0)
            {
                num++;
                continue;
            }

            Console.WriteLine(num);
            num++;
        }

        Console.WriteLine("\nSum elements of an example array using foreach:");
        int[] numbers = { 3, 5, 7, 9, 11 };
        int total = 0;
        foreach (int val in numbers)
        {
            total += val;
        }
        Console.WriteLine($"Array elements: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Sum of array elements = {total}");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
