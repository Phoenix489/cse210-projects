using System;

class Program
{

    static void Main(string[] args)
    {
    Toaster toaster = new Toaster();
    Console.WriteLine(toaster.GetStatus());
    toaster.TurnOn();
    Console.WriteLine(toaster.GetStatus());
    toaster.TurnOff();
    Console.WriteLine(toaster.GetStatus());
    }
}

public abstract class SmartDevice
{
    protected Boolean _status;
    protected string _name;
    public DateTime _onTime;
    public DateTime _offTime;
    public DateTime _timeOn;

    public Boolean GetStatus()
    {
        return _status;
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
        _offTime = DateTime.Now;
    }

    public void TimeOn()
    {
        // _timeOn = _offTime - _onTime; 
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
