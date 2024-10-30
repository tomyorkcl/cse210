using System;
using System.Collections.Generic;

public abstract class Sport
{
    private DateTime _date;
    private int _minutes;

    protected Sport(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} - {GetType().Name} ({Minutes} min): " +
               $"Distance: {GetDistance()} " +
               $"{(GetType() == typeof(Swimming) ? "km" : "miles")}, " +
               $"Speed: {GetSpeed()} {(GetType() == typeof(Swimming) ? "kph" : "mph")}, " +
               $"Pace: {GetPace()} min per {(GetType() == typeof(Swimming) ? "km" : "mile")}";
    }
}