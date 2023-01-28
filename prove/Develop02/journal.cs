using System.Collections.Generic;
public class Journal{
    public string _featureSelection;
    public List<string> Entry = new List<string>();

    public void Display()
    {
        Console.WriteLine("Please Select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }
    public void EntryDisplay(){

    }
    
}