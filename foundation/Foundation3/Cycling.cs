public class Cycling : Sport
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (GetSpeed() / 60) * Minutes;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / GetSpeed();
}