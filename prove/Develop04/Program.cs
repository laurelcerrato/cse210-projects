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
                Breathing breath = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.DisplayStart();
                breath.DisplayEnd();
                // Console.WriteLine("Going to sleep for a second...");
                // Thread.Sleep(5000);
            }else if (choice == "2"){
                Reflecting reflect = new Reflecting("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.DisplayStart();
        
            }else if(choice == "3"){
                Listing listing = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.DisplayStart();

        }
    }
}       
}