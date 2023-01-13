using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning Activity: Loops");
        int userGuess = -1;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,200);
        int numberOfGuesses = 0;
        while (userGuess != number)
        {
            Console.Write("What is your guess: ");
            userGuess = int.Parse(Console.ReadLine());
            numberOfGuesses += 1;
            if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < number)
            {
            Console.WriteLine("Higuer!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You guessed {numberOfGuesses} times");
            }
        }
    }
}