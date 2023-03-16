public class Simple: Goal{
    public void CreateSimpleGoal(){
        base.GoalInfo();
    }
    public override string fileGoal(){
        return $"Simple,{_name},{_description},{_goalPoints}";
    }
}
