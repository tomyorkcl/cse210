public class ChecklistGoal : Goal
{
    private int amountCompleted;
    private int target;
    private int bonus;

    public int AmountCompleted => amountCompleted;
    public int Target => target;
    public int Bonus => bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        this.target = target;
        this.bonus = bonus;
        amountCompleted = 0;
    }

    public override void MarkCompleted()
    {
        amountCompleted++;
        if (amountCompleted >= target)
        {
            points += bonus;
        }
    }

    internal void SetProgress(int target, int amountCompleted)
    {
        this.target = target;
        this.amountCompleted = amountCompleted;
    }
}