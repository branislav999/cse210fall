using System.Dynamic;

public class Address
{
    private string _street;
    private int _number;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, int number, string city, string state, string country)
    {
        _street = street;
        _number = number;
        _city = city;
        _state = state;
        _country = country;

    } 

    public string GetAddress()
    {
        return $"{_street} {_number}, {_city}. {_state}. {_country}";
    }
}