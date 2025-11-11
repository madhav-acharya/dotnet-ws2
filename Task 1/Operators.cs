namespace Task_1;
public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Sum: {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Difference: {a - b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Product: {a * b}");
    }

    public void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return;
        }
        // If you want integer division result:
        Console.WriteLine($"Quotient (integer): {a / b}");
        // If you want floating point precise result:
        Console.WriteLine($"Quotient (float): {(double)a / b}");
    }

    public void OddEvenFinder(int number)
    {
        // Ternary operator used to determine odd/even
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}