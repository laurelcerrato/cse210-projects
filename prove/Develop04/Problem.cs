public class Problem : Activity{
    private List<string> _problems = new List<string>(){
        "Climate Change.",
        "Health Care.",
        "Food Insecurity.",
        "Violence.",
        "Homelessness.",
        "Sustainability.",
        "Education."
    };
    public Problem(string name, string activitydescription): base(name, activitydescription){

    }
    public void DisplayProblem(){
        string problem = base.Random(_problems);
        Console.Write($"Think and write about your opinion on the following real world Problem: \n---- {problem} ----\nWhen you have something in mind press enter to continue. ");
        string enter = Console.ReadLine();
        Console.Write("\nYou may begin in: ");
        base.Countdown();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        Console.Clear();
        while (DateTime.Now < futureTime){
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}