using System;

class Program
{//For creativity I added another activity called Real world Problem activity 
//that displays a random problem and asks to reflect and write about it
    static void Main(string[] args)
    {   Console.Clear();
        string choice = "";
        while (choice != "5"){
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Start Real World Problem Activity\n5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1"){
                Breathing breath = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.DisplayStart();
                breath.BreathingDisplay();
                breath.DisplayEnd();
            }else if (choice == "2"){
                Reflecting reflect = new Reflecting("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.DisplayStart();
                reflect.DisplayReflecting();
                reflect.DisplayEnd();
        
            }else if(choice == "3"){
                Listing listing = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.DisplayStart();
                listing.DisplayListing();
                listing.DisplayEnd();
        }   else if(choice == "4"){
            //CREATIVITY
            Problem listing = new Problem("Real World Problem","This activity will help you reflect on a real world problem and write about it.");
                listing.DisplayStart();
                listing.DisplayProblem();
                listing.DisplayEnd();
        }
    }
}       
}