using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _secondVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetSecondVerse()
    {
        return _secondVerse;
    }

    public void SetSecondVerse(string secondVerse)
    {
        _secondVerse = secondVerse;
    }

    public string GetFullReference()
    {
        if (_secondVerse == null)
        {
            //Print the scripture reference as a string (example: Nephi 1:1)
            string fullReference = ($"{_book} {_chapter}:{_verse}");
            return fullReference;
        }
        else
        {
            //Print the scripture reference as a string (example: Nephi 1:1-2)
            string fullReference = ($"{_book} {_chapter}:{_verse}-{_secondVerse}");
            return fullReference;
        }
    }

}