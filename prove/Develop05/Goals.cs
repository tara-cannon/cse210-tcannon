using System;

public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _isComplete;
    protected int _checklistTimes;
    protected bool _checkBonus = false;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetComplete()
    {
        return _isComplete;
    }

    public void SetComplete(string isComplete)
    {
        _isComplete = isComplete;
    }

    public int GetChecklistTimes()
    {
        return _checklistTimes;
    }

    public void SetChecklistTimes(int checklistTimes)
    {
        _checklistTimes += checklistTimes;
    }

    public bool GetCheckBonus()
    {
        return _checkBonus;
    }

    public void SetCheckBonus(bool checkBonus)
    {
        _checkBonus = checkBonus;
    }

    public abstract int GetPointsAwarded();

    public abstract int GetTimes();

    public abstract int GetBonus();
}