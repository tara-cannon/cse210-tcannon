using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> goals = new List<Goals>();

        int totalPoints = 0;
        int totalChecklistTimes = 0;

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
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Console.WriteLine("");
            
            return choice;
        }

        static string UserGoal()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1: Simple Goal");
            Console.WriteLine("2: Eternal Goal");
            Console.WriteLine("3: Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string goalChoice = Console.ReadLine();

            Console.WriteLine("");

            return goalChoice;
        }

        static string GetName()
        {
            Console.Write("What is the name of your goal? ");
            return Console.ReadLine();
        }

        static string GetShortDescription()
        {
            Console.Write("What is a short description of it? ");
            return Console.ReadLine();
        }

        static int GetPoints()
        {
            string _pointsEntered = "";
            int _points = 0;
            
            Console.Write("What is the amount of points associated with this goal? ");
            _pointsEntered = Console.ReadLine();
            _points = int.Parse(_pointsEntered);
            return _points;
        }

        static int GetHowManyTimes()
        {
            string _timesEntered = "";
            int _times = 0;

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            
            _timesEntered = Console.ReadLine();
            _times = int.Parse(_timesEntered);

            return _times;
        }

        static int GetBonusAmount()
        {
            string _bonusEntered = "";
            int _bonus = 0;

            Console.Write("What is the bonus for accomplishing it that many times? ");
            
            _bonusEntered = Console.ReadLine();
            _bonus = int.Parse(_bonusEntered);

            return _bonus;
        }

        static void DisplayGoals(List<Goals> list)
        {
            int _counter = 0;
            Console.WriteLine("The goals are:");
            foreach (Goals g in list)
            {
                _counter += 1;
                Console.WriteLine($"{_counter}. {g.GetName()}");
            }
        
        }

        static int GoalAccomplished(List<Goals> list)
        {  
            int _counter = 0;
            int _pointsAccomplished = 0;
            int _bonusPoints = 0;
            Console.Write("Which goal did you accomplish? ");
            
            string _numberEntered = Console.ReadLine();
            int _number = int.Parse(_numberEntered);

            foreach (Goals g in list)
            {                
                _counter += 1;
                if (_counter == _number)
                {
                    _pointsAccomplished = g.GetPointsAwarded();
                }
            }
            return _pointsAccomplished;
        }

        static int GoalAccomplishedHowManyTimes(List<Goals> list)
        {  
            int _numberOfTimes = 0;

            foreach (Goals g in list)
            {                
                if (g.ToString() == "ChecklistGoals")
                {
                    _numberOfTimes = 1;                    
                }
                
            }
            return _numberOfTimes;
        }

        //static string GetStringRepresentation()
        //{
            
        //}

#endregion

        while(!exitProgram)
        {
            Console.WriteLine("");
            Console.WriteLine("You have " + totalPoints + " points.");
            Console.WriteLine("");

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
                            ChecklistGoals checklist = new ChecklistGoals(GetName(), GetShortDescription(), GetPoints(), GetHowManyTimes(), GetBonusAmount());
                            goals.Add(checklist);
                        break;
                    }

                break;

                //List Goals               
                case "2":
                    int _counter = 0;
                    Console.WriteLine("The goals are:");
                foreach (Goals g in goals)
                {
                    //string goalDescription = g.GetDescription();
                    //string goalName = g.GetName();
                    //int goalPoints = g.GetPoints();
                    //int goalTimes = g.GetTimes();
                    //int goalBonus = g.GetBonus();
                    //need g.GetCompleted();
                    string _goalCompleted = "";
                    string _nameOfGoal = g.ToString();
                    _counter += 1;

                    if (_nameOfGoal == "SimpleGoals")
                    {
                        _goalCompleted = "X";
                    }
                    else if (_nameOfGoal == "ChecklistGoals" && g.GetBonus() == totalChecklistTimes);
                    {
                        _goalCompleted = "X";
                    }
                    else
                    {
                        _goalCompleted = " ";
                    }

                    if (_nameOfGoal == "ChecklistGoals")
                    {
                        Console.WriteLine($"{_counter}. [{_goalCompleted}] {g.GetName()} ({g.GetDescription()}) -- Currently completed: {totalChecklistTimes}/{g.GetTimes()}");
                    }
                    else
                    {
                        Console.WriteLine($"{_counter}. [{_goalCompleted}] {g.GetName()} ({g.GetDescription()})");
                    }
                    
                }
                break;

                //Save Goals
                case "3":
                    //Ask the user for a file name and write out all entries
                    Console.Write("Save file as: ");
                    string saveFileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(saveFileName))
                    {
                        foreach (Goals g in goals)
                        {
                            string goalDescription = g.GetDescription();
                            string goalName = g.GetName();
                            int goalPoints = 0; //need to remove when working
                            //int goalPoints = g.GetPoints();
                            //int goalPoints = g.GetPointsAwarded();
                            //int goalTimes = g.GetTimes();
                            //int goalBonus = g.GetBonus();
                            //string saveGoals = GetStringRepresentation();
                            outputFile.WriteLine(g + ":" + goalName + "," + goalDescription + "," + goalPoints);
                        }
                    }

                    break;

                //Load Goals
                case "4":
                    //Ask the user for the file to load
                    Console.Write("What is the file name? ");
                    string loadFileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(loadFileName);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    break;

                //Record Event
                case "5":
                    DisplayGoals(goals);
                    int _accomplished = GoalAccomplished(goals);
                    totalPoints += _accomplished;
                    int _isChecklist = GoalAccomplishedHowManyTimes(goals);
                    totalChecklistTimes += _isChecklist;
                    break;
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