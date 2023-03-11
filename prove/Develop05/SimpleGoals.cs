using System;

public class SimpleGoals : Goals
{
    public override int GetTimes()
    {
        return 0;
    }

    public override int GetPointsAwarded()
    {
        return _points;
    }

    public override int GetBonus()
    {
        return 0;
    }

}