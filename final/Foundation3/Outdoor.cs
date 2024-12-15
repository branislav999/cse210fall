public class Outdoor : Event
{
    private int _temperature;
    

    public Outdoor(string title, string description, string date, string time, Address address, int temperature) 
    : base (title, description, date, time, address)
    {
        _temperature = temperature;
    }

    public override void FullDisplay()
    {
        BasicDisplay();
        Console.WriteLine($"The temperature will be F{_temperature}.");
    }
}