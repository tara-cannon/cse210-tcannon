using System;

public class BreathingActivity : Activity
{
    private string _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _activityName = "Breathing Activity";

    public void DisplayBreathingActivity()
    {
        GetActivityDisplay(_activityName, _activityDescription);       
        DisplayBreatheInAndOut(_seconds);
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void DisplayBreatheInAndOut(int _seconds)
    {
        for ( int i = 0; i < _seconds; i++)     //Each loop is 10 seconds
        {            
            Console.WriteLine("");
            Console.WriteLine("Breathe in...");
            GetCountdown();
            Console.WriteLine("Breathe out...");
            GetCountdown();
        }
    }
}