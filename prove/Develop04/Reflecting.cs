public class Reflecting:Activity{
    private List<string> _reflecQuestions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Reflecting(string name, string activitydescription): base(name, activitydescription)
    {
    }
}