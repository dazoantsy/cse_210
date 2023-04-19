using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage (0 - 100) ");
        string gradePercentage = Console.ReadLine();
        int gradeInt = int.Parse(gradePercentage);
        string letter = "";

        if (gradeInt >= 90)
        {
            letter = "A";
        }

        else if (gradeInt >= 80)
        {
            letter = "B";
        }

        else if (gradeInt >= 70)
        {
            letter = "C";
        }

        else if (gradeInt >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");
        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulation, you have passed.");
        }
        else
        {
            Console.WriteLine("We are sorry that you could not pass, you will surely pass next time.");
        }
    }
}