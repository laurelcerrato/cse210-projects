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
    public override string OrganizedGoal()
    {
        return  $"{_name} ({_description}) -- Currently Completed = {_timesCompleted}/{_timestoComplete}";
    }
}