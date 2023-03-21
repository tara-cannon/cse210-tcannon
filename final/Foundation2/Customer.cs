using System;

//The customer contains a name and an address.

//The name is a string, but the Address is a class.

//The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

public class Customer
{
    //public List<Address> _address = new List<Address>();
    private string _customerName;
    private string _addressName = "";
    private string _cityProvince = "";
    private string _state = "";
    private string _zipcode = "";
    private string _country = "";

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

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

    public void GatherAddress(List<Address> _address)
    {
        Address address1 = new Address();
        address1.SetAddressName("123 Main");
        address1.SetCityProvince("Anywhere");
        address1.SetState("UT");
        address1.SetZipcode("84041");
        address1.SetCountry("USA");
        _address.Add(address1);
    }
}