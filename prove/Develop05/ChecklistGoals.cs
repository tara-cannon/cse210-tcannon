using System;

public class ChecklistGoals : Goals
{
    private int _howMany = 0;
    private int _bonusPoints = 0;
    

    public int GetHowMany()
    {
        return _howMany;
    }

    public void SetHowMany(int howMany)
    {
        _howMany = howMany;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }    
    
    public override int GetTimes()
    {
        return _howMany;
    }

    public override int GetPointsAwarded()
    {
        return _points;
    }

    public override int GetBonus()
    {
        return _bonusPoints;
    }
}