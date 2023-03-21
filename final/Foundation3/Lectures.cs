public class Lectures : Event
{
    private string _speakerName = "";
    private string _capacity = "";

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }

    public string GetFullDetailsForLectures()
    {
        return $" | Speaker Name: {_speakerName} | Capacity: {_capacity}";
    }
}