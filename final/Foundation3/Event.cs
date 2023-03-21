public class Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";
    private string _eventType = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title} | Description: {_description} | {_date} | {_time} | Address: {_address}";
    }

    public string GetFullDetails()
    {
        return $"Title: {_title} | Description: {_description} | {_date} | {_time} | Address: {_address} | Event: {_eventType}";
    }

    public string GetShortDescription()
    {
        return $"Event: {_eventType} | Title: {_title} | {_date}";
    }

}