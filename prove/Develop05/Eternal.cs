public class Eternal: Goal{
    public void CreateEternalGoal(){
        base.GoalInfo();
    }
    public override string fileGoal(){
        return $"Eternal,{_name},{_description},{_goalPoints}";
    }
    
    
}
