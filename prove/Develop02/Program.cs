using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program!");    
        Journal journal = new Journal();
        journal._featureSelection = "0";
        Entries entry = new Entries();
        while (journal._featureSelection != "5"){
            journal.Display();
            journal._featureSelection = Console.ReadLine();

            if (journal._featureSelection == "1"){
            PrompGenerator prompt = new PrompGenerator();
            string randomPrompt = prompt.QuestionPrompt();
            Console.WriteLine(randomPrompt);
            Console.Write(">>> ");

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            entry._entryDate = dateText;
            entry._promptQuestion = randomPrompt;
            entry._promptAnswerEntry = Console.ReadLine();
            // entry.Entry.Add(entry._promptAnswerEntry);
            // entry.Entry.Add(entry._promptQuestion);
            // entry.Entry.Add(entry._entryDate);
            // Console.WriteLine(entry._entryDate);
            // Console.WriteLine(entry._promptAnswerEntry);
            // Console.WriteLine(entry._promptQuestion);
            } else if (journal._featureSelection == "2"){
                entry.JournalEntry();


            }else if (journal._featureSelection == "3"){
                Console.WriteLine("Option 3 Selected");

            }
            else if (journal._featureSelection == "4"){
                Console.WriteLine("Option 4 Selected");

            }else if (journal._featureSelection == "5"){
                Console.WriteLine("Thank you for using this Journal!");
            }
        }
        
    }
}