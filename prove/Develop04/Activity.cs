public class Activity{
    protected int _seconds;
    private string _activityName;
    private string _activityDescription;
    public Activity(){

    }
    public Activity (string activityname, string activitydescrip){
        activityname = _activityName;
        activitydescrip = _activityDescription;
    }
    public void DisplayStart(){
        Console.WriteLine($"Welcome to the {_activityName} activity");
        Console.WriteLine($"{_activityDescription}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _seconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready ...");
    }
    public void DisplayEnd(){
        Console.WriteLine("Well done!! \n");
        Console.WriteLine($"You have completed another {_seconds} of the {_activityName}.");
        
    }
    public void Countdown(){
        for (int a = 5; a >= 0; a--)
        {
            Console.WriteLine("\rYou may begin in: {0}", a);
            System.Threading.Thread.Sleep(1000);
        } 
    }
    public void Spinner(){
        while(true){
                Console.Write("/");
                Console.SetCursorPosition(Console.CursorLeft -1,Console.CursorTop);
                System.Threading.Thread.Sleep(200);
                Console.Write("\\");
                Console.SetCursorPosition(Console.CursorLeft -1,Console.CursorTop);
                System.Threading.Thread.Sleep(200);
                Console.Write("|");
                Console.SetCursorPosition(Console.CursorLeft -1,Console.CursorTop);
                System.Threading.Thread.Sleep(200);
                }
    }
}