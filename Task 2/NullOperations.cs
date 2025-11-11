namespace Task_1;

public class NullOperations
{
    // Method to perform all null checks and operations
    public void PerformNullChecks()
    {
        // Declaring a string variable and assigning null
        string username = null;

        // Checking if username is null using the Ternary Operator (? :)
        string message = (username == null) ? "Username is not available" : username;
        Console.WriteLine(message);

        // Performing null checking using the Null-Coalescing Operator (??)
        Console.WriteLine(username ?? "Username is not available (checked using ??)");

        // Using the Null-Coalescing Assignment Operator (??=)
        username ??= "DefaultUser";

        // Printing the updated value of username
        Console.WriteLine($"Updated Username: {username}");
    }
}