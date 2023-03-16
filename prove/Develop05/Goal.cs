public class Goal{
    protected int _points = 0;
    private int _typeofGoal;
    protected string _name;
    protected string _description;
    protected string _goalPoints;
    protected bool _isCompleted;

    public int GetScore(){
        return _points;
    }
    public int GetGoaltype(){
        return _typeofGoal;
    }
    public virtual void GoalInfo(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the ammount of points associated with the goal? ");
        _goalPoints = Console.ReadLine();
    }
    public virtual string OrganizedGoal(){
        return  $"{_name} ({_description})";
    }
}