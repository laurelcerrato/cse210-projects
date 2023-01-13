using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        Console.WriteLine("Please enter a number, when you are finished type 0. ");
        int userNumber = -1;
        while (userNumber != 0)
        {   Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int digit in numbers)
        {
            sum += digit;
            
        }
        Console.WriteLine($"The sum of the numbers is {sum} ");
        int listCount = numbers.Count;
        int average = sum / listCount;
        Console.WriteLine($"The average is: {average} ");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }    

}

