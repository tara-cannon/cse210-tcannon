using System;

public class BreathingActivity : Activity
{
    private string _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _activityName = "Breathing Activity";

    public void DisplayBreathingActivity()
    {
        GetActivityDisplay(_activityName, _activityDescription);  
        DisplayBreatheInAndOut();
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void DisplayBreatheInAndOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_theseSeconds);  

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("");
            Console.WriteLine("Breathe in...");
            GetCountdown(5);
            Console.WriteLine("Breathe out...");
            GetCountdown(5);
        }
    }
}