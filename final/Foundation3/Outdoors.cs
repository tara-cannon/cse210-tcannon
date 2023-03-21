public class Outdoors : Event
{
    private string _weatherStatement = "";

    public string GetWeatherStatement()
    {
        return _weatherStatement;
    }

    public void SetWeatherStatement(string weatherStatement)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetailsForOutdoor()
    {
        return $" | Weather Statement: {_weatherStatement}";
    }
}