public class Goal{
    protected int _points = 0;
    private int _typeofGoal;
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _isCompleted = false;
    public virtual bool SetCompleted(){
        _isCompleted = true;
        return _isCompleted;
    }
    public int GetScore(){
        return _points;
    }
    public int SetScore(int points){
        return _points = points;
    }
    public int GetGoaltype(){
        return _typeofGoal;
    }
    public int GetGoalPoints(){
        return _goalPoints;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public void SetGoalPoints(int goalpoints){
        _goalPoints = goalpoints;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetDescription(string descrip){
        _description = descrip;
    }
    public virtual void GoalInfo(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the ammount of points associated with the goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }
    public virtual string GetGoal()
    {
        string goalText = $"[ ] {_name} ({_description})";

        if(_isCompleted == true)
        {
            goalText = $"[X] {_name} ({_description})";
            _goalPoints = 0;
        }

        return goalText;
    }
    public virtual string fileGoal(){
        return "";
    }
    public virtual void CompletedGoal(int points){

    }
}