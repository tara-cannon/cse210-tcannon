using System;

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
}