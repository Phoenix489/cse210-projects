public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double lengthMins, double speed)
    : base(date, lengthMins)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = GetSpeed() * (GetLengthInMins() / 60.0);
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance()} miles, Speed: {GetSpeed()}mph, Pace: {GetPace()} min per mile";
    }
}