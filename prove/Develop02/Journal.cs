using System;

public class Journal
{
    public List<NewEntry> _entries = new List<NewEntry>();

    public void DisplayJournal() 
    {
        foreach (NewEntry entry in _entries)
        {
            entry.DisplayNewEntry();
        }
    }
}