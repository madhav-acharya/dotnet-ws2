using System;

public class DayFinder
{
    public void FindDayOfWeek()
    {
        Console.Write("Enter a number (1-7) to get the day of the week: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int dayNumber))
        {
            Console.WriteLine("\n--- Day of Week Check (Switch Statement) ---");
            
            string dayName;
            
            switch (dayNumber)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            
            Console.WriteLine($"Input {dayNumber}: {dayName}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }
    }
}