public class Listing: Activity{
    private List<string> _questions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _answers = 0;
    public Listing(string name, string activitydescription): base(name, activitydescription)
    {
    }
    public void DisplayListing(){
        string question = base.Random(_questions);
        Console.Write($"List as many responses you can to the following question: \n---- {question} ----\nYou may begin in: ");
        base.Countdown();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        Console.Clear();
        while (DateTime.Now < futureTime){
            Console.Write(">>> ");
            Console.ReadLine();
            _answers++;
        } 
        Console.WriteLine($"\nYou listed {_answers} answers!");
    }
}