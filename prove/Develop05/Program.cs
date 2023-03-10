using System;

class Program
{
    static void Main(string[] args)
    {
        string chosen = "";
        while(chosen != "6"){
            Goal goal = new Goal();
            goal.DisplayMenu();
            Console.Write("Select a choice from the Menu: ");
            chosen = Console.ReadLine();
            
            if (chosen == "1"){
                goal.CreateNewGoal();
            }
        }
    }
}