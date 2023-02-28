public class Activity{
    protected int _seconds;
    private string _activityName;
    private string _activityDescription;
    private  List<string> _animation = new List<string>();
    public Activity(){

    }
    public Activity (string name, string descrip){
        _activityName = name;
        _activityDescription=descrip ;
    }
    public void DisplayStart(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity");
        Console.WriteLine($"\n{_activityDescription}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _seconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready ...");
        Spinner();
    }
    public void DisplayEnd(){
        Console.WriteLine("Well done!! \n");
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_activityName} activity.");
        Thread.Sleep(5000);
        Console.Clear();
        
    }
    public void Countdown(){
        for (int a = 5; a >= 0; a--)
        {
            Console.WriteLine("\rYou may begin in: {0}", a);
            System.Threading.Thread.Sleep(1000);
        } 
    }
    public void Spinner(){
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);
        int i = 0;
        while(DateTime.Now < endTime){
                    string a = _animation[i];
                    Console.Write(a);
                    Thread.Sleep(400);
                    Console.Write("\b \b");
                    i++;
                    if(i >= _animation.Count){
                        i = 0;
                    }
                
        }
    }
    public int GetSeconds(){
        return _seconds;
    }
}