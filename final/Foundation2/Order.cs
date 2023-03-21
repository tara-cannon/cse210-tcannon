using System;

public class Order
{
    public List<Product> _products = new List<Product>();
    public List<Customer> _customer = new List<Customer>();
    public List<Address> _address = new List<Address>();

    public void GatherOrder()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        DisplayTotalPrice();
    }

    public double GetTotalCost()
    {
        double _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.GetPriceOfProduct();
        }
        return _totalCost;
    }

    public double GetShippingCost()
    {
        double _shippingCost = 0;
        foreach (Address address in _address)
        {
            _shippingCost = address.IsUSA(address.GetCountry());
        }
        return _shippingCost;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetProductName()}\nProduct ID: {product.GetProducID()}");
        }
        Console.WriteLine("");
    }

    public void DisplayShippingLabel()
    { 
        Console.WriteLine("Shipping Label");
        
        foreach (Customer customer in _customer)
        {
            Console.WriteLine(customer.GetCustomerName());            
        }

        foreach (Address address in _address)
        {
            Console.WriteLine($"{address.GetAddress()}\n");
        }
    } 

    public void DisplayTotalPrice()
    { 
        double _totalPrice = GetTotalCost();
        double shippingFee = GetShippingCost();
        _totalPrice += shippingFee;
        Console.WriteLine($"Total Price: ${_totalPrice}\n\n");
    }  
}