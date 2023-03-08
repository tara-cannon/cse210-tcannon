using System;

public class SimpleGoals : Goals
{
    //private string _pointsEntered;
    //private int _points;

    public SimpleGoals(string name, string description, int points) : base (name, description)
    {
        _points = points;
        //_complete = complete;
    }
/*
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
        return 0;
    }

    public override int GetBonus()
    {
        return 0;
    }
}