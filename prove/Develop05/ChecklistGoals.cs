using System;

public class ChecklistGoals : Goals
{
    private string _pointsEntered;
    private int _points;

    public ChecklistGoals(string name, string description, int points) : base (name, description)
    {
        _points = points;
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

    public override int GetPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal?");
        _pointsEntered = Console.ReadLine();
        _points = int.Parse(_pointsEntered);
        return _points;
    }
    
}