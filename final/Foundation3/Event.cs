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
    
    public void BasicDisplay()
    {
        Console.WriteLine("Event Details");
        Console.WriteLine($"Title: {_title} ({_description}). On {_date} at {_time}");
        Console.WriteLine($"The address of the event is: {_address.GetAddress()}");
    }

    public virtual void FullDisplay()
    {

    }

    public void ShortDisplay()
    {
        Console.WriteLine("Event Details");
        Console.WriteLine($"Title: {_title} on {_date}");
    }
    
}