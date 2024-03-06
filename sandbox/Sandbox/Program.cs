using System;

class Program
{

    static void Main(string[] args)
    {
    Toaster toaster = new Toaster();
    Console.WriteLine(toaster.IsOn());
    toaster.TurnOn();
    Console.WriteLine(toaster.IsOn());
    Thread.Sleep(5000);
    toaster.TurnOff();
    Console.WriteLine(toaster.IsOn());
    Console.WriteLine(toaster.ElapsedTimeOn());
    }
}

public abstract class SmartDevice
{
    protected Boolean _status;
    protected string _name;
    public DateTime _onTime;

    public string IsOn()
    {
        if (_status == true)
        {
            return $"{_name} is on.";
        }

        else 
        {
            return $"{_name} is off.";
        }
    }

    public string GetName()
    {
        return _name;
    }

    public void TurnOn()
    {
        _status = true;
        _onTime = DateTime.Now;

    }

    public void TurnOff()
    {
        _status = false;
    }

    public string ElapsedTimeOn()
    {
        TimeSpan elapsedTime = DateTime.Now - _onTime;
        return $"{_name} was on for: {elapsedTime}";
    }
}

public class Toaster : SmartDevice
{
    public Toaster()
    {
        _name = "Toaster";
        _status = false;
    }

}
