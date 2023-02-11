using System;

class Program
{
    static void Main(string[] args)
    {      
        List<string> scriptureList = new List<string>()
        {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."
        };

        Reference reference = new Reference("John","3","16","17");
        
        var myReference = reference.GetFullReference();

        Scripture scripture = new Scripture(scriptureList[0]);

        var myScripture = scripture.GetWholePhrase();
        
        List<string> list = new ();
        list = myScripture.Split(" ").ToList();

        List<string> removeList = new ();
        removeList = myScripture.Split(" ").ToList();

        Word w = new Word();

        w.GetWholePhrase(myScripture,list,myReference,removeList);
    }
}