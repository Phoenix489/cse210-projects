public class Reception : Event
{
    private string _email;


    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"Event Type: Reception\nRSVP Email: {_email}";
    }
}
