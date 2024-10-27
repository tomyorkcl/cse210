public class SimpleGoal : Goal
{
    public bool IsComplete { get; set; }

    public SimpleGoal(string name, string description, int points)
    {
        ShortName = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public override void MarkCompleted()
    {
        IsComplete = true;
    }
}