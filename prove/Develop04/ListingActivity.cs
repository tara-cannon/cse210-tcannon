using System;

public class ListingActivity : Activity
{
    private string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _activityName = "Listing Activity";
    private string _prompt = "";
    private int _numberOfResponses = 0;

    List<string> promptList = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _responseList = new List<string>();

    public void DisplayListingActivity()
    {
        GetActivityDisplay(_activityName, _activityDescription);
        ListingGoodThings();
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void ListingGoodThings()
    {
        Console.WriteLine("List as namy responses you can to the following prompt:");
        Random random = new Random();
        int promptNum = random.Next(0,4);
        _prompt = promptList[promptNum];
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine("You may begin in:");
        _secondsRemaining = 3;
        GetCountdown();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_theseSeconds);  
        DateTime currentTime = DateTime.Now;

        do
        {
            string response = Console.ReadLine();
            _responseList.Add(response);
            currentTime = DateTime.Now;
            
        } while (currentTime < futureTime);
        
        _numberOfResponses = _responseList.Count;

        Console.WriteLine($"You listed {_numberOfResponses} items!");
    }

}