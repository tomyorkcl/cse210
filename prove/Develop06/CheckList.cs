public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    public int Target { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        ShortName = name;
        Description = description;
        Points = points;
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
    }

    public override void MarkCompleted()
    {
        AmountCompleted++;
        if (AmountCompleted >= Target)
        {
            Points += Bonus;
        }
    }
}