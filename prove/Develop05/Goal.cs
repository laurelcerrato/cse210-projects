public class Goal{
    private int _points = 0;
    private string _typeofGoal;
    private string _name;
    private string _description;
    private string _goalPoints;
    private List<string> _goals = new List<string>();

    public int GetScore(){
        return _points;
    }
    public void DisplayMenu(){
        Console.WriteLine($"Your score is : {_points}\n");
        Console.WriteLine($"Menu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
    }
    public void CreateNewGoal(){
        Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
        _typeofGoal = Console.ReadLine();
    }
    public virtual void GoalInfo(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        _goals.Add(_name);
        Console.Write("What is a short description of it");
        _description = Console.ReadLine();
        _goals.Add(_description);
        Console.Write("What is the ammount of points associated with the goal? ");
        _goalPoints = Console.ReadLine();
        _goals.Add(_goalPoints);
    }
}