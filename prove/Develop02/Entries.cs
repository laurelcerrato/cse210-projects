public class Entries{
    public string _promptAnswerEntry = "";
    public string _entryDate= "";
    public string _promptQuestion= "";
    public string _filename;
    public void JournalEntry()
    {
        Console.WriteLine($"Date: {_entryDate}");
        Console.WriteLine($"Prompt Question: {_promptQuestion}");
        Console.WriteLine($"Prompt Answer: {_promptAnswerEntry}");
        
    }
}