using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;

        Journal journal = new Journal();

        journal.DisplayJournal();

    //Journal prompts, stored in a list
        List<string> promptList = new List<string>()
        {
            "What makes you feel most confident?",
            "What were you grateful for today?",
            "What was the most beautiful thing you saw today?",
            "What made you smile today?",
            "What is your favorite holiday?",
            "If you could change one thing about today, what would it be?",
            "Who are you grateful to have in your life?"
        };

    //Menu options
        Console.WriteLine("Welcome to the Journal Program!");

        static string UserChoice()
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1: Write a New Entry");
            Console.WriteLine("2: Display Journal Entry");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save to Folder");
            Console.WriteLine("5: Quit Journal Program");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();

            return choice;
        }

        while(!exitProgram)
        {
            //User selects what they want to do
            string choiceSelected = UserChoice();

            //Take Users option and execute
            switch(choiceSelected)
            {
                //Write a new entry
                case "1":
                //Randomize the items in the Prompt list
                Random random = new Random();
                int num = random.Next(0, 6);
                //Entry 1 of the journal
                NewEntry entry1 = new NewEntry();
                //Chooses a random prompt
                entry1._prompt = promptList[num];
                Console.WriteLine(entry1._prompt);
                //Ask the user to respond to the prompt
                Console.Write("Your response: ");
                string userEntryResponse = Console.ReadLine();
                entry1._response = userEntryResponse;
                //Add this journal entry to the Journal list
                journal._entries.Add(entry1);

                break;

                //Display Entry                
                case "2":
                journal.DisplayJournal();

                break;

                //Load
                case "3":
                //Ask the user for the file to load
                Console.Write("What is the file name? ");
                string loadFileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFileName);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                break;

                //Save to Folder
                case "4":
                //Ask the user for a file name and write out all entries
                Console.Write("Save file as: ");
                string saveFileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(saveFileName))
                {
                    foreach (NewEntry entry in journal._entries)
                    {
                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("MM-dd-yyyy")} - Prompt: {entry._prompt}");
                        outputFile.WriteLine($"Response: {entry._response}");
                    }
                }

                break;

                //Quit Program
                case "5":
                    exitProgram = true;
                break;

                //(Above and beyond element) Error handling
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }
}