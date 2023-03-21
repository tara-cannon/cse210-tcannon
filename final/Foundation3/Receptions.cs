public class Receptions : Event
{
    private string _email = "";

    public string GetEmail()
    {
        return _email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetFullDetailsForReception()
    {
        return $" | Please RSVP at: {_email}";
    }
}