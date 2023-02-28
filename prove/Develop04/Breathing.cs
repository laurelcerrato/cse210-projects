public class Breathing: Activity{
    private string _breath1 = "Breath in...";
    private string _breath2 = "Now breath out...";

    public Breathing(string name, string activitydescription): base(name, activitydescription)
    {
    }
    public void BreathingDisplay(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        Console.Clear();
        while (DateTime.Now < futureTime) {
            Console.Write($"\n\n{_breath1}"); base.Countdown();
            Console.Write($"\n\n{_breath2}");base.Countdown();
        }
    }
}