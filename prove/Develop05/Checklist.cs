public class Checklist: Goal{
    private int _timesCompleted = 0;
    private int _bonusPoints = 0;
    public override void GoalInfo()
    {
        base.GoalInfo();
        Console.Write("How many times does this goal needs to be accomplished to have a bonus? ");
        _timesCompleted = int.Parse(Console.ReadLine());
        Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        
    }
}