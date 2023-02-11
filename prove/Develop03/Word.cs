using System;

public class Word
{
    public void GetWholePhrase(string wholePhrase, List<string> list, string reference, List<string> removeList)
    {
        Console.WriteLine(reference + " " + wholePhrase);
        
        string finalPhrase = wholePhrase;
        string removePhrase = wholePhrase;

        do
        {        
            Random rnd = new Random();
            int index = rnd.Next(0, list.Count);
            string word = list[index];
            //This list will keep track of remaining characters, forcing the program to exit when it is empty.
            string removeWord = removeList[index];

            Console.WriteLine("Please, press 'Enter' to continue or type 'Exit' to quit.");
            string response = Console.ReadLine().ToUpper();

            string newWord = "";
            string removeNewWord = "";

            for ( int i = 0; i < word.Length; i++)
            {
                newWord += "_";
                //Each time a character in the newWord list is changed to "_", the same character is removed from the removeWord list.
                removeNewWord += "";                
            }

            list[index] = newWord;
            removeList[index] = removeNewWord;

            finalPhrase = "";
            removePhrase = "";

            for (int i = 0; i < list.Count; i++)
            {
                finalPhrase += list[i].ToString() + " ";
                removePhrase += removeList[i].ToString();
            }

            string showPhrase = reference + " " + finalPhrase;

            if (response != "EXIT")
            {
                Console.Clear();
                Console.WriteLine(showPhrase);
            }
            else
            {
                Console.WriteLine("");
            }

            if (response == "EXIT")
            {
                break;
            }
        } while (removePhrase.Length > 0);
    }
}