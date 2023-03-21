public class Swimming : Activity
{
    private int _laps = 0;

    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }


    public override double CalculateDistance()
    {
        double _howManyMeters = (_laps * 50);
        double _totalMeters = Math.Round(((_howManyMeters / 1000) * 0.62), 2);
        
        return _totalMeters;
    }
}