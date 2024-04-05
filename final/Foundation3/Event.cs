public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} / {_time}\n{_address.GetAddressInfo()}";
    }

     public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDetails()
    {
        return $"{GetType().Name} - {_title} - {_date}";    
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _address;
    }
}