public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, double lengthMins, double numberOfLaps)
    : base(date, lengthMins)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance =  _numberOfLaps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / (GetLengthInMins() / 60.0);
    return speed;
    }

    public override double GetPace()
    {
        double pace = GetLengthInMins() / GetDistance();
        return pace;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Laps - {_numberOfLaps}, Distance: {GetDistance()} km, Speed: {GetSpeed()}kph, Pace: {Math.Round(GetPace(), 2)} min per km";
    }
}