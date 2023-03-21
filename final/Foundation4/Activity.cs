public class Activity
{
    private string _todaysDate = "";
    private int _minutes = 0;
    private double _distance = 0;
    private double _speed = 0;
    private double _pace = 0;
    private double _miles = 0;

    public string GetTodaysDate()
    {
        return _todaysDate;
    }

    public void SetTodaysDate(string todaysDate)
    {
        _todaysDate = todaysDate;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public double GetMiles()
    {
        return _miles;
    }

    public void SetMiles(double miles)
    {
        _miles = miles;
    }

    public virtual double CalculateDistance()
    {
        _distance = _miles;
        return _distance;
    }

    public virtual double CalculateSpeed(double howFar)
    {
        _speed = Math.Round(((howFar / _minutes) * 60), 1);
        return _speed;
    }

    public virtual double CalculatePace(double howFar)
    {
        _pace = Math.Round((_minutes / howFar), 1);
        return _pace;
    }

    public virtual string GetSummary(string activityType)
    {
        return ($"{_todaysDate} {activityType} ({_minutes} min)");
    }
}