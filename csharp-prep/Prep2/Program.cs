using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade Percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = " ";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade letter is {letter}.");

        if (gradePercentage < 70)
        {
            Console.Write("Good luck next time.");
        }
        else
        {
            Console.Write("Congrats");
        }
    }
}