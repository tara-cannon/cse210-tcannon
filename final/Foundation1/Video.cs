using System;

public class Video
{
    public string _title;
    public string _author;
    public double _seconds;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_seconds} Seconds");
        int _numberOfCommentsPerVideo = NumberOfComments(_comments);
        Console.WriteLine($"Number of Comments: {_numberOfCommentsPerVideo}");
        foreach (Comment item in _comments)
        {
            item.DisplayComments();
        }
    }

    static int NumberOfComments(List<Comment> commentNumbers)
    {
        int _counter = 0;
        foreach (Comment c in commentNumbers)
        {
            _counter += 1;
        }
        return _counter;
    }

}