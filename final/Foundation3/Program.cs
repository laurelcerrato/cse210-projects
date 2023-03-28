using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Planning Event Program");
        List<Event> events = new List<Event>();
        Address address1 = new Address("20 SE Street","SPS","Cortes");
        string addresse1 = address1.AddresInfo();
        Lecture lecture = new Lecture("The Little Prince","This event consist of a full day of reading the Little Prince","19/03/2023","5:00PM",addresse1,"Lecture Event","Laura Smith",100);

        Address address2 = new Address("5 SN Avenue","Miami","Florida");
        string addresse2 = address2.AddresInfo();
        Outdoor outdoor = new Outdoor("Fathers Day Celebration","This event consist of a full day of sharing with your father","20/02/2023","2:30PM",addresse2,"Outdoor Event","Sunny, 30 Celcius");

        Address address3 = new Address("10th Street","Yoro","Trujillo");
        string addresse3 = address3.AddresInfo();
        Reception reception = new Reception("Meet James Mcgill","In this event you'll get to know James Mcgill","25/07/2023","6:00PM",addresse3,"Reception Event","reception@gmail.com");
    
        events.Add(lecture);
        events.Add(outdoor);
        events.Add(reception);
        foreach(Event eve in events ){
            Console.WriteLine("Standard Details: ");
            eve.Standard();
            Console.WriteLine();
            eve.FullDetails();
            Console.WriteLine();
            eve.Short();
            Console.WriteLine();
        }
    }
}