using System;

//The address contains a string for the street address, the city, state/province, and country.

//The address should have a method that can return whether it is in the USA or not.

//The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

public class Address
{
    private string _addressName = "";
    private string _cityProvince = "";
    private string _state = "";
    private string _zipcode = "";
    private string _country = "";


    public string GetAddressName()
    {
        return _addressName;
    }

    public void SetAddressName(string addressName)
    {
        _addressName = addressName;
    }

    public string GetCityProvince()
    {
        return _cityProvince;
    }

    public void SetCityProvince(string cityProvince)
    {
        _cityProvince = cityProvince;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetZipcode()
    {
        return _zipcode;
    }

    public void SetZipcode(string zipcode)
    {
        _zipcode = zipcode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_addressName}\n{_cityProvince} {_state} {_zipcode} {_country}";
    }

    public int IsUSA(string inUSA)
    {
        if (inUSA == "USA")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }




    /*private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    /*public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }


    public int IsUSA(string inUSA)
    {
        if (inUSA == "USA")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetAddressLine()
    {
        Customer customer1 = new Customer();
        customer1.SetCustomerName("First Customer");
        Console.WriteLine(customer1.GetCustomerName()); 

        int shippingCost = IsUSA(_country);
        Console.WriteLine(shippingCost); 

        string results = ($"{_street} {_city} {_stateOrProvince} {_country}");
        return results;
    }*/
}