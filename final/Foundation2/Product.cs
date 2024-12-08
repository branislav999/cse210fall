public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    


    public Product()
    {

    }
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }

    public double Total()
    {
        return _price * _quantity;   
    }

    public string Label()
    {
        return $"Name of the product: {_name}, Product ID: {_productId}";
    }


}
