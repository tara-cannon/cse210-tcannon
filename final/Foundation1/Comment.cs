using System;

public class Comment
{
    public string _name;
    public string _text;

    public void DisplayComments()
    {
        Console.Write($"Comment: ");
        Console.WriteLine($"{_name} - {_text}");
    }
}