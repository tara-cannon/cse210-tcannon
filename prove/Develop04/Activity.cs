using System;

public class Activity
{
    public int _seconds = 30;
    public int _secondsRemaining = 0;
    public string _secondsInputted = "";

    public int _theseSeconds = 0;
    private int counter;

    public void GetActivityDisplay(string _activityName, string _activityDescription)
    {
        GetStartingMessage(_activityName, _activityDescription);
        Console.WriteLine("How long, in increments of 10 seconds, would you like for your session?");
        _secondsInputted = Console.ReadLine();        
        _theseSeconds = int.Parse(_secondsInputted);        
        _seconds = GetSeconds(_theseSeconds);
        GetReady(); 
    }

    public void GetStartingMessage(string _activityName, string _activityDescription)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine($"");
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine($"");
    }

    public void GetEndingMessage(string _displaySeconds, string _displayActivityName)
    {
        Console.WriteLine("");
        Console.WriteLine($"Well done!!");
        GetSpinner(12);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_displaySeconds} seconds of the {_displayActivityName}.");
        GetSpinner(12);
        Console.Clear();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine($"Get ready...");
        GetSpinner(12);
        Console.WriteLine("");
    }

    public void GetSpinner(int howManyTimesAround)
    {
        for ( int i = 0; i < howManyTimesAround; i++)
        {
            counter++;        
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Thread.Sleep(500);            
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); 
            Console.Write(" \b");
        }
    }

    public void GetCountdown()
    {
        int howManySeconds = 0;
        if (_secondsRemaining > 5)
        {
            _secondsRemaining -= 5;
            howManySeconds = 5;
        }
        else
        {
            howManySeconds = _secondsRemaining;
            _secondsRemaining = 0;
        }

        for ( int i = 0; i < howManySeconds; i++)
        {
            counter = howManySeconds - i;
            
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); 
        }
        Console.Write(" \b");
    }

    private int GetSeconds(int secondsInputted)
    {
        return (secondsInputted / 10);
    }
}