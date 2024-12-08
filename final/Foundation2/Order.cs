using System.Dynamic;

public class Order
{
    List<Product> _products = new List<Product>{};
    Customer _customer = new Customer();
    Address _address = new Address();
    Product _product = new Product();

    

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void DisplayOrderCost()
    {
        
        double _sum = 0;

        foreach (Product _product in _products)
        {
            _sum += _product.Total();
        }
        if (_customer.IsInUsa())
        {
            _sum += 5;
        }
        else 
        {
            _sum += 35;
        }
        
        Console.WriteLine($"\nTotal cost of the order: {_sum}");

    }

    public void AddProduct(Product _product)
    {
        _products.Add(_product);
    }

    public void DisplayOrderLabel()
    {
        Console.WriteLine("\nThese are the order labels: ");
        foreach (Product _product in _products)
        {
            Console.WriteLine(_product.Label());
        }

    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(_customer.GetLabel());
    }


}


