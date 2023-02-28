public class Reflecting:Activity{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflecting(string name, string activitydescription): base(name, activitydescription)
    {
    }
    public void DisplayReflecting(){
        Console.Clear();
        string prompt = base.Random(_prompts);
        Console.Write($"Consider the following Prompt\n---- {prompt} ----\nWhen you have something in mind press enter to continue. ");
        string enter = Console.ReadLine();
        Console.Write("Now ponder on each of the folowing questions as they related to this experience.\nYou may begin in: ");
        base.Countdown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        while(DateTime.Now < futureTime){
            string question = base.Random(_questions);
            Console.Write($"\n>>> {question} ");
            base.Spinner();
        }
    }
}