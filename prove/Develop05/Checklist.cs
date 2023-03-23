public class Checklist: Goal{
    private int _timesCompleted = 0;
    private int _timestoComplete = 0;
    private int _bonusPoints = 0;
    public override void GoalInfo()
    {
        base.GoalInfo();
        Console.Write("How many times does this goal needs to be accomplished to have a bonus? ");
        _timestoComplete = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        
    }
    public int GetTimescompleted(){
        return _timesCompleted;
    }
    public int GetTimestocomplete(){
        return _timestoComplete;
    }
    public int Getbonuspoints(){
        return _bonusPoints;
    }
    public void SetTimescompleted(int timescompleted){
        _timesCompleted = timescompleted;
    }
    public void SetTimestocomplete(int timestocomplete){
        _timestoComplete = timestocomplete;
    }
    public void Setbonuspoints(int bonus){
        _bonusPoints = bonus;
    }
    public override string GetGoal()
    {   string goalText = $"[ ] {_name} ({_description}) -- Currently Completed = {_timesCompleted}/{_timestoComplete}";

        if(_isCompleted == true)
        {
            goalText = $"[X] {_name} ({_description}) -- Currently Completed = {_timesCompleted}/{_timestoComplete}";
            _goalPoints = 0;
        }

        return goalText;
    }
    public override string fileGoal(){
        return $"Checklist,{_name},{_description},{_goalPoints},{_bonusPoints},{_timestoComplete},{_timesCompleted}";
    }
    public override bool SetCompleted(){
        _timesCompleted++;
        if (_timesCompleted == _timestoComplete){
            _goalPoints = _goalPoints + _bonusPoints;
            _isCompleted = true;
        }
    
        return _isCompleted;
    }
}