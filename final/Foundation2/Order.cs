using System;

//Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label
//, and can return a string for the shipping label.

//The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.

//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5.
//If the customer does not live in the USA, then the shipping cost is $35.

//A packing label should list the name and product id of each product in the order.

//A shipping label should list the name and address of the customer

public class Order
{
    private double _totalPrice = 0;
    public List<Product> _products = new List<Product>();
    //public List<Address> _address = new List<Address>();
    public List<Customer> _customer = new List<Customer>();

    public double GetTotalCost()
    {
        double _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.GetPriceOfProduct();
        }
        return _totalCost;
    }

    public void GatherOrder()
    {
        //GatherProducts();
        _totalPrice = GetTotalCost();

        //Customer customer = new Customer();
        //customer.SetCustomerName("John Smith");
        //customer.GatherAddress(_address);
        //int shippingFee = _address.IsUSA();
        //_totalPrice += shippingFee;

        Console.WriteLine(_totalPrice);

        DisplayPackingLabel();
        DisplayShippingLabel();
        //DisplayShippingLabel(customer);
    }

    public void GatherProducts()
    {
        Product product1a = new Product();
        product1a.SetProductName("Fudge");
        product1a.SetProductID("1234ABCD");
        product1a.SetPrice(20);
        product1a.SetQuantity(2);

        //Console.WriteLine(product1a.GetPriceOfProduct());

        //Add product1b and product1c
        Product product1b = new Product();
        product1b.SetProductName("Cake");
        product1b.SetProductID("9876EFGH");
        product1b.SetPrice(20);
        product1b.SetQuantity(2);

        _products.Add(product1a);
        _products.Add(product1b);
    }

    

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetProductName()}\n{product.GetProducID()}");
        }
    }

    public void DisplayShippingLabel()
    { //name of customer and address
        Console.WriteLine("Shipping Label:");
        
        foreach (Customer customer in _customer)
        {
            Console.WriteLine(customer.GetCustomerName());
            Console.WriteLine($"{customer.GetAddress()}");
        }
    }
    
    /*public void DisplayShippingLabel(Customer customer)
    { //name of customer and address
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(customer.GetCustomerName());
        foreach (Address address in _address)
        {
            Console.WriteLine($"{address.GetAddress()}");
        }
    }

    /*public void DisplayOrder();
    {
        Console.WriteLine("");
    }
*/
    
}