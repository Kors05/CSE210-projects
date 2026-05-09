using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        // Letter grade variable
        string letter = "";

        // Determine letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Pass/fail check
        if (percent >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}