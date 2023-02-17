using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Laurel Cerrato", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment1 = new MathAssignment("Xiomara Ramirez","Fractions", "Section 5", "Problems 1-10");
        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WrittingAssignment writting1 = new WrittingAssignment("Juan Jose", "Europe","The reinassance");
        Console.WriteLine(writting1.GetWrittingInfo());
    }
}