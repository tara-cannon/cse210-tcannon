using System;

public class Activity
{
    private int counter;

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
        GetSpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_displaySeconds} seconds of the {_displayActivityName}.");
        GetSpinner();
        Console.Clear();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine($"Get ready...");
        GetSpinner();
        Console.WriteLine("");
    }

    public void GetSpinner()
    {
        for ( int i = 0; i < 12; i++)
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

        for ( int i = 0; i < 5; i++)
        {
            counter = 5 - i;
            
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); 
        }
        Console.Write(" \b");
    }

    public int GetSeconds(int secondsInputted)
    {
        return (secondsInputted / 10);
    }
}