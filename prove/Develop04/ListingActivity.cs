using System;

public class ListingActivity : Activity
{
    private string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _activityName = "Listing Activity";
    private string _prompt = "";

    List<string> promptList = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //private List<Response> _response = new List<Response>();

    public void DisplayListingActivity()
    {
        GetActivityDisplay(_activityName, _activityDescription);
        ListingGoodThings();
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void ListingGoodThings()
    {
        Console.WriteLine("List as namy responses you can to the following prompt:");
    }

}