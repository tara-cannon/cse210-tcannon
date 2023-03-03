using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> goals = new List<Goals>();

        bool exitProgram = false;

        
#region Menu Functions

        static string UserChoice()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            return choice;
        }

        static string UserGoal()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1: Simple Goal");
            Console.WriteLine("2: Eternal Goal");
            Console.WriteLine("3: Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create? ");

            string goalChoice = Console.ReadLine();

            return goalChoice;
        }

        static string GetName()
        {
            Console.WriteLine("What is the name of your goal?");
            return Console.ReadLine();
        }

        static string GetShortDescription()
        {
            Console.WriteLine("What is a short description of it?");
            return Console.ReadLine();
        }

        static int GetPoints()
        {
            string _pointsEntered = "";
            int _points = 0;
            
            Console.WriteLine("What is the amount of points associated with this goal?");
            _pointsEntered = Console.ReadLine();
            _points = int.Parse(_pointsEntered);
            return _points;
        }
#endregion


        while(!exitProgram)
        {
            Console.WriteLine("You have points."); //Todo

            string choiceSelected = UserChoice();

            switch(choiceSelected)
            {
                //Create New Goal
                case "1":

                    string goalSelected = UserGoal();

                    switch(goalSelected)
                    {
                        case "1":
                            SimpleGoals simple = new SimpleGoals(GetName(), GetShortDescription(), GetPoints());
                            goals.Add(simple);
                        break;

                        case "2":
                            EternalGoals eternal = new EternalGoals(GetName(), GetShortDescription(), GetPoints());
                            goals.Add(eternal);
                        break;

                        case "3":
                            ChecklistGoals checklist = new ChecklistGoals(GetName(), GetShortDescription(), GetPoints());
                            goals.Add(checklist);
                        break;
                    }

                break;

                //List Goals               
                case "2":
                //goals.DisplayGoals();
                Console.WriteLine("this is your list.");
                //ListGoals listGoals = new ListGoals(goals[0]);
                for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine(goals[i]);
                    }
                //ListGoals listGoals = new ListGoals();
                //listGoals = goals.ToList();
                //listGoals = goals.Split(",").ToList();
                //ListGoals.DisplayGoals();
                break;

                //Save Goals
                case "3":
                    //Ask the user for a file name and write out all entries
                    /*Console.Write("Save file as: ");
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
*/
                //Load Goals
                case "4":
                    //Ask the user for the file to load
                    /*Console.Write("What is the file name? ");
                    string loadFileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(loadFileName);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    break;
*/
                //Record Event
                case "5":

                //Quit Program
                case "6":
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