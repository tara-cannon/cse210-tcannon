using System;

public class ChecklistGoals : Goals
{
    //private string _pointsEntered;
    private int _times;
    private int _bonus;

    public ChecklistGoals(string name, string description, int points, int times, int bonus) : base (name, description)
    {
        _points = points;
        _times = times;
        _bonus = bonus;
    }
/*
    public int GetTimes()
    {
        return _times;
    }

    public void SetTimes(int times)
    {
        _times = times;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public override string NameOfYourGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        return Console.ReadLine();
    }

    public override string ShortDescription()
    {
        Console.WriteLine("What is a short description of it?");
        return Console.ReadLine();
    }


    public int GetTimes()
    {
        return _times;
    }

    public int GetBonus()
    {
        return _bonus;
    }
*/
    public override int GetPointsAwarded()
    {
        //Console.WriteLine("What is the amount of points associated with this goal?");
        //_pointsEntered = Console.ReadLine();
        //_points = int.Parse(_pointsEntered);
        return _points;
    }

    public override string GetCompleted()
    {
        return "X";
    }

    public override string GetRecordEvent()
    {
        return "X";
    }

    public override int GetTimes()
    {
        return _times;
    }

    public override int GetBonus()
    {
        return _bonus;
    }
    
}