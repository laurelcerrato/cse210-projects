using System;

class Program
{
    static void Main(string[] args)
    {   Console.Clear();
        string choice = "";
        while (choice != "4"){
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1"){
                Console.WriteLine("Going to sleep for a second...");
                Thread.Sleep(5000);
            Console.WriteLine("I'm back!!");
            }else if (choice == "2"){
                Activity ac = new Activity();
                Console.Write("Choice 2 ");ac.Countdown();
            }
        }
    }
}       