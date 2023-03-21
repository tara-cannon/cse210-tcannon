using System;

class Program
{
    static void Main(string[] args)
    {
        Event event1 = new Event();
        event1.SetTitle("World Cup");
        event1.SetDescription("Soccer tournament in the USA in 2030");
        event1.SetDate("June 15th");
        event1.SetTime("7:00pm");
        event1.SetEventType(event1.ToString());

        Address address1 = new Address();
        address1.SetAddressName("123 Main");
        address1.SetCityProvince("Anywhere");
        address1.SetState("UT");
        address1.SetZipcode("84041");
        address1.SetCountry("USA");
        event1.SetAddress(address1.GetAddress());

        Console.WriteLine("");
        Console.WriteLine("-Standard Details-");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine("-Full Detils-");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine("-Short Description-");
        Console.WriteLine(event1.GetShortDescription());


        Lectures lectures1 = new Lectures();
        lectures1.SetTitle("His Grace is Sufficient");
        lectures1.SetDescription("BYU Speeches");
        lectures1.SetDate("July 12");
        lectures1.SetTime("7:00pm");
        lectures1.SetEventType(lectures1.ToString());
        lectures1.SetSpeakerName("Brad Wilcox");
        lectures1.SetCapacity("500 People");

        Address address2 = new Address();
        address2.SetAddressName("456 Center Street");
        address2.SetCityProvince("Clearfield");
        address2.SetState("UT");
        address2.SetZipcode("84089");
        address2.SetCountry("USA");
        lectures1.SetAddress(address2.GetAddress());

        Console.WriteLine("");
        Console.WriteLine("-Standard Details-");
        Console.WriteLine(lectures1.GetStandardDetails());
        Console.WriteLine("-Full Details-");
        Console.Write(lectures1.GetFullDetails());
        Console.WriteLine(lectures1.GetFullDetailsForLectures());
        Console.WriteLine("-Short Description-");
        Console.WriteLine(lectures1.GetShortDescription());


        Receptions receptions1 = new Receptions();
        receptions1.SetTitle("Wedding");
        receptions1.SetDescription("Reception for Lana and David");
        receptions1.SetDate("August 18");
        receptions1.SetTime("6:00pm-8:00pm");
        receptions1.SetEventType(receptions1.ToString());
        receptions1.SetEmail("rsvp@here.com");

        Address address3 = new Address();
        address3.SetAddressName("789 Best Blvd");
        address3.SetCityProvince("CloudNine");
        address3.SetState("UT");
        address3.SetZipcode("84090");
        address3.SetCountry("USA");
        receptions1.SetAddress(address3.GetAddress());

        Console.WriteLine("");
        Console.WriteLine("-Standard Details-");
        Console.WriteLine(receptions1.GetStandardDetails());
        Console.WriteLine("-Full Details-");
        Console.Write(receptions1.GetFullDetails());
        Console.WriteLine(receptions1.GetFullDetailsForReception());
        Console.WriteLine("-Short Description-");
        Console.WriteLine(receptions1.GetShortDescription());


        Outdoors outdoors1 = new Outdoors();
        outdoors1.SetTitle("Laying Sod");
        outdoors1.SetDescription("Help the Burton family lay sod in their yard");
        outdoors1.SetDate("May 15");
        outdoors1.SetTime("9:00am");
        outdoors1.SetEventType(outdoors1.ToString());
        outdoors1.SetWeatherStatement("Clear and beautiful for yard work");

        Address address4 = new Address();
        address4.SetAddressName("246 West 975 South");
        address4.SetCityProvince("Hooper");
        address4.SetState("UT");
        address4.SetZipcode("84062");
        address4.SetCountry("USA");
        outdoors1.SetAddress(address4.GetAddress());

        Console.WriteLine("");
        Console.WriteLine("-Standard Details-");
        Console.WriteLine(outdoors1.GetStandardDetails());
        Console.WriteLine("-Full Details-");
        Console.Write(outdoors1.GetFullDetails());
        Console.WriteLine(outdoors1.GetFullDetailsForOutdoor());
        Console.WriteLine("-Short Description-");
        Console.WriteLine(outdoors1.GetShortDescription());

    }
}