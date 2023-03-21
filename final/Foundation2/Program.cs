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

        //Console.WriteLine(product1a.GetPriceOfProduct());

        //Add product1b and product1c
        Product product1b = new Product();
        product1b.SetProductName("Cake");
        product1b.SetProductID("9876EFGH");
        product1b.SetPrice(20);
        product1b.SetQuantity(2);

        order1._products.Add(product1a);
        order1._products.Add(product1b);

        Customer customer = new Customer();
        customer.SetCustomerName("John Smith");
        customer.SetAddressName("123 Main");
        customer.SetCityProvince("Anywhere");
        customer.SetState("UT");
        customer.SetZipcode("84041");
        customer.SetCountry("USA");
        order1._customer.Add(customer);


        order1.GatherOrder();

        /*
        Product product1a = new Product();
        product1a.SetProductName("Fudge");
        product1a.SetProductID("1234ABCD");
        product1a.SetPrice(20);
        product1a.SetQuantity(2);

        Console.WriteLine(product1a.GetPriceOfProduct());

        //Add product1b and product1c
        Product product1b = new Product();
        product1b.SetProductName("Fudge");
        product1b.SetProductID("1234ABCD");
        product1b.SetPrice(20);
        product1b.SetQuantity(2);

        Address address1 = new Address();
        address1.SetAddressName("123 Main");
        address1.SetCityProvince("Anywhere");
        address1.SetState("UT");
        address1.SetZipcode("84041");
        address1.SetCountry("USA");
        product1a.SetAddress(address1.GetAddress());*/

        /*Address address1 = new Address();
        address1.SetStreet("123 Main");
        address1.SetCity("Anywhere");
        address1.SetStateOrProvince("UT");
        address1.SetCountry("USA");    

        Console.WriteLine(address1.GetAddressLine());    
*/
        //Order order1 = new Order();
        //order.Add(product1a);
        //order1._products.Add(product1a);
        //order1._products.Add(product1b);

        
    }
}