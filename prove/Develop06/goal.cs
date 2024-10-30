using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    protected string shortName;
    protected string description;
    protected int points;

    public string ShortName => shortName;
    public string Description => description;
    public int Points => points;

    protected Goal(string name, string description, int points)
    {
        shortName = name;
        this.description = description;
        this.points = points;
    }

    public abstract void MarkCompleted();
}
