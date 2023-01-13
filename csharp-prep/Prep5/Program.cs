using System;

class Program
{
    static void Main(string[] args)    
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

    }
}