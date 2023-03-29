using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program");
        List<Activity> activities = new List<Activity>();
        Running running = new Running("09-03/2023",20,"Running",20);
        Cycling cycling = new Cycling("08/04/2023",30,"Cycling",7);
        Swimming swimming = new Swimming("05/03/2023",20,"Swimming",10);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        foreach(Activity activity in activities){
            Console.WriteLine(activity.Summary());
        }
    }
}