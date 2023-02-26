using System;

public class Activity
{
    public string _secondsInputted = "";
    public int _secondsRemaining = 0;
    public int _theseSeconds = 0;

    public void GetActivityDisplay(string activityName, string activityDescription)
    {
        GetStartingMessage(activityName, activityDescription);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _secondsInputted = Console.ReadLine();        
        _theseSeconds = int.Parse(_secondsInputted);
        GetReady(); 
    }

    public void GetStartingMessage(string activityName, string activityDescription)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine($"");
        Console.WriteLine($"{activityDescription}");
        Console.WriteLine($"");
    }

    public void GetEndingMessage(string displaySeconds, string displayActivityName)
    {
        Console.WriteLine("");
        Console.WriteLine($"Well done!!");
        GetSpinner(12);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {displaySeconds} seconds of the {displayActivityName}.");
        GetSpinner(12);
        Console.Clear();
    }

    //Displays "Get ready..." while pausing the program and displaying a spinner
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine($"Get ready...");
        GetSpinner(12);
        Console.WriteLine("");
    }

    //Pauses the program while displaying a spinner
    //Length of time will change in Reflection Activity, depending on time user inputs for activity
    public void GetSpinner(int howManyTimesAround)
    {
        int _spinner = 0;
        for ( int i = 0; i < howManyTimesAround; i++)
        {
            _spinner++;        
            switch (_spinner % 4)
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

    //Pauses program while displaying a numerical countdown
    //Length of time will change in Breathing Activity, depending on time user inputs for activity
    public void GetCountdown(int numberOfSeconds)
    {        
        int _counter = 0;
        for ( int i = 0; i < numberOfSeconds; i++)
        {
            _counter = numberOfSeconds - i;
            
            Console.Write(_counter);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); 
        }
        Console.Write(" \b");
    }
}