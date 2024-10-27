using System;

public class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public virtual void MarkCompleted() { }
}
