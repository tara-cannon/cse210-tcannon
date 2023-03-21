using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();

        Product product1a = new Product();
        product1a.SetProductName("Fudge");
        product1a.SetProductID("1234ABCD");
        product1a.SetPrice(20);
        product1a.SetQuantity(2);

        Product product1b = new Product();
        product1b.SetProductName("Cake");
        product1b.SetProductID("9876EFGH");
        product1b.SetPrice(20);
        product1b.SetQuantity(2);

        order1._products.Add(product1a);
        order1._products.Add(product1b);

        Customer customer = new Customer();
        customer.SetCustomerName("John Smith");
        order1._customer.Add(customer);

        Address address = new Address();
        address.SetAddressName("123 Main");
        address.SetCityProvince("Anywhere");
        address.SetState("UT");
        address.SetZipcode("84041");
        address.SetCountry("USA");
        order1._address.Add(address);

        order1.GatherOrder();

        Order order2 = new Order();

        Product product2a = new Product();
        product2a.SetProductName("Brownie Mix");
        product2a.SetProductID("88976MIX");
        product2a.SetPrice(12);
        product2a.SetQuantity(20);

        Product product2b = new Product();
        product2b.SetProductName("Ice Cream");
        product2b.SetProductID("00989ICE");
        product2b.SetPrice(100);
        product2b.SetQuantity(5);

        order2._products.Add(product2a);
        order2._products.Add(product2b);

        Customer customer2 = new Customer();
        customer2.SetCustomerName("Anne Taylor");
        order2._customer.Add(customer2);

        Address address2 = new Address();
        address2.SetAddressName("58 Manchester Lane");
        address2.SetCityProvince("Burningham");
        address2.SetState("ENGLAND");
        address2.SetZipcode("54GHK");
        address2.SetCountry("UK");
        order2._address.Add(address2);

        order2.GatherOrder();
    }
}