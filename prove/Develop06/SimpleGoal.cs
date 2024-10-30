
public class SimpleGoal : Goal
{
    private bool isComplete;

    public bool IsComplete => isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isComplete = false;
    }

    public override void MarkCompleted()
    {
        isComplete = true;
    }
}