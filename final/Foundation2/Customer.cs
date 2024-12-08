public class Customer
{
    private string _name;
    private Address _address;
    
    public bool IsInUsa()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    
    public string GetLabel()
    {
        return $"{_name}{_address.GetAddress()}";
    }


    public Customer()
    {

    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}

