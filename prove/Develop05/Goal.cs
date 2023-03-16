public class Goal{
    protected int _points = 0;
    private int _typeofGoal;
    protected string _name;
    protected string _description;
    protected string _goalPoints;
    private List<string> _goals = new List<string>();

    public int GetScore(){
        return _points;
    }
    public int GetGoaltype(){
        return _typeofGoal;
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
    }
    public void ListGoals(){
        string output = $"Goal Name: {_goals[0]} Goal Description: {_goals[1]}";
        Console.WriteLine(output);
    }
}