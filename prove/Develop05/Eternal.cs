public class Eternal: Goal{
    public void CreateEternalGoal(){
        base.GoalInfo();
    }
    public override string fileGoal(){
        return $"Eternal,{_name},{_description},{_goalPoints}";
    }
    public override string GetGoal(){
        string goalText = $"[ ] {_name} ({_description})";
        return goalText;
    }
    public override bool SetCompleted(){
        _isCompleted = true;
        return _isCompleted;
    }
    
}
