public class Reception : Event
{
    private string _link;

    public Reception(string title, string description, string date, string time, Address address, string email  ) 
    : base (title, description, date, time, address)
    {
        _link = email;
    }

    public override void FullDisplay()
    {
        BasicDisplay();
        Console.WriteLine($"Please enter the link to the registration page: {_link}");
    }

}