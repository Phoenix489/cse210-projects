public class Running : Activity
{
    private double _distance;

    public Running(string date, double lengthMins, double distance)
    : base(date, lengthMins)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / GetLengthInMins() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLengthInMins() / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance()} miles, Speed: {GetSpeed()}mph, Pace: {GetPace()} min per mile";
    }
}