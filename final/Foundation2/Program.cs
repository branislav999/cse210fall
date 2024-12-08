class Program
{
    static void Main()
    {
        Address usaAddress = new Address("51 S 1 St E", "Rexburg", "ID", "USA");
        Address nonUsaAddress = new Address("Lepavinska 25", "Beograd", "Vojvodina", "Serbia");

        Customer usaCustomer = new Customer("Tom Hanks", usaAddress);
        Customer nonUsaCustomer = new Customer("Emma Watson", nonUsaAddress);

        Product laptop = new Product("Laptop", "12345", 1200, 1);
        Product phone = new Product("Phone", "67890", 500, 2);

        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(laptop);
        usaOrder.AddProduct(phone);

        Order nonUsaOrder = new Order(nonUsaCustomer);
        nonUsaOrder.AddProduct(laptop);
        nonUsaOrder.AddProduct(phone);

        usaOrder.DisplayOrderLabel();
        usaOrder.DisplayOrderCost();
        usaOrder.DisplayShippingLabel();

        nonUsaOrder.DisplayOrderLabel();
        nonUsaOrder.DisplayOrderCost();
        nonUsaOrder.DisplayShippingLabel();
    }
}
