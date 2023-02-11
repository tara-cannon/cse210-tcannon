using System;

public class Scripture
{    
    private string _phrase;

    //Constructors
    public Scripture()
    {
        _phrase = "Unknown";
    }

    public Scripture(string wholePhrase)
    {
        _phrase = wholePhrase;
    }

    public string GetPhrase(){
        return _phrase;
    }

    public void SetPhase(string phraseToSet)
    {
        _phrase = phraseToSet;
    }
    
    public string GetWholePhrase()
    {
        string phraseToReturn = _phrase;
        return phraseToReturn;
    }    
}
