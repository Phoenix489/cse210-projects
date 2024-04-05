using System.Diagnostics.CodeAnalysis;

public class Activity
{
    private string _date;
    private double _lengthMins;


    public Activity(string date, double lengthMins)
    {
        _date = date;
        _lengthMins = lengthMins;
    }

    public double GetLengthInMins()
    {
        return _lengthMins;
    }
    public virtual double GetDistance()
    { 
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthMins} mins): ";
    }
}