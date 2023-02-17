using System.Collections.Generic;
public class Journal{
    public string _featureSelection = "0";
    public int _writinginTheJournal = 0;

    public void Display()
    {
        Console.WriteLine("Please Select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }
    
}