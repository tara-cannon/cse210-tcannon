using System;

//Contains the name, product id, price, and quantity of each product.

//The price of this product is computed by multiplying the price and the quantity.

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private double _quantity;    
    private string _address;

    /*public Product(string productName, string productID, double price, double quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
*/
    public double GetPriceOfProduct()
    {
        return (_price * _quantity);
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    
    public string GetProducID()
    {
        return _productID;
    }

    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }
    
    public double GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(double quantity)
    {
        _quantity = quantity;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }
    
}