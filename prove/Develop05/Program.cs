using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> goals = new List<Goals>();

        int totalPoints = 0;
        //int totalChecklistTimes = 0;

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

        static string NameOfYourGoal()
        {
            Console.Write("What is the name of your goal? ");
            return Console.ReadLine();
        }

        static string ShortDescription()
        {
            Console.Write("What is a short description of it? ");
            return Console.ReadLine();
        }

        static int NumberOfPoints()
        {
            string _pointsEntered = "";
            int _points = 0;
            
            Console.Write("What is the amount of points associated with this goal? ");
            _pointsEntered = Console.ReadLine();
            _points = int.Parse(_pointsEntered);
            return _points;
        }

        static int HowManyTimes()
        {
            string _timesEntered = "";
            int _times = 0;

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            
            _timesEntered = Console.ReadLine();
            _times = int.Parse(_timesEntered);

            return _times;
        }

        static int BonusAmount()
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

            Console.Write("Which goal did you accomplish? ");
            
            string _numberEntered = Console.ReadLine();
            int _number = int.Parse(_numberEntered);

            foreach (Goals g in list)
            {                
                _counter += 1;
                if (_counter == _number)
                {
                    _pointsAccomplished = g.GetPointsAwarded();

                    if (g.ToString() == "SimpleGoals")
                    {
                        g.SetComplete("X");        
                    }
                    else if (g.ToString() == "ChecklistGoals")
                    {
                        g.SetChecklistTimes(1);
                        
                        if (g.GetChecklistTimes() == g.GetTimes())
                        {
                            g.SetComplete("X"); 
                        }                                   
                    }                    
                }
            }

            return _pointsAccomplished;
        }

        /*static void GoalAccomplishedHowManyTimes(List<Goals> list)
        {  
            foreach (Goals g in list)
            {                
                if (g.ToString() == "SimpleGoals")
                {
                    g.SetComplete("X");        
                }
                else if (g.ToString() == "ChecklistGoals")
                {
                    g.SetChecklistTimes(1);
                    
                    if (g.GetChecklistTimes() == g.GetTimes())
                    {
                        g.SetComplete("X"); 
                    }                                   
                }                
            }
        }
*/
        static int GoalBonus(List<Goals> list)
        {  
            int _counter = 0;
            int _bonusAccomplished = 0;

            foreach (Goals g in list)
            {                
                _counter += 1;
                if (g.GetChecklistTimes() == g.GetTimes() && g.ToString() == "ChecklistGoals" && g.GetCheckBonus() != true)
                {
                    _bonusAccomplished = g.GetBonus();
                    g.SetCheckBonus(true);
                }
            }
            return _bonusAccomplished;
        }
        static string GetStringRepresentation(Goals goals)
        {
            if (goals.ToString() == "SimpleGoals")
            {
                return ($"{goals}:{goals.GetName()},{goals.GetDescription()},{goals.GetPointsAwarded()},{goals.GetComplete()}");
            }
            else if (goals.ToString() == "EternalGoals")
            {
                return ($"{goals}:{goals.GetName()},{goals.GetDescription()},{goals.GetPointsAwarded()}");
            }
            else
            {
                return ($"{goals}:{goals.GetName()},{goals.GetDescription()},{goals.GetPointsAwarded()},{goals.GetBonus()},{goals.GetTimes()},{goals.GetChecklistTimes()}");
            }
        }

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
                            SimpleGoals simple = new SimpleGoals();
                            simple.SetName(NameOfYourGoal());
                            simple.SetDescription(ShortDescription());
                            simple.SetPoints(NumberOfPoints());
                            simple.SetComplete(" ");
                            goals.Add(simple);
                        break;

                        case "2":
                            EternalGoals eternal = new EternalGoals();
                            eternal.SetName(NameOfYourGoal());
                            eternal.SetDescription(ShortDescription());
                            eternal.SetPoints(NumberOfPoints());
                            eternal.SetComplete(" ");
                            goals.Add(eternal);
                        break;

                        case "3":
                            ChecklistGoals checklist = new ChecklistGoals();
                            checklist.SetName(NameOfYourGoal());
                            checklist.SetDescription(ShortDescription());
                            checklist.SetPoints(NumberOfPoints());
                            checklist.SetChecklistTimes(0);
                            checklist.SetHowMany(HowManyTimes());
                            checklist.SetBonusPoints(BonusAmount());
                            checklist.SetComplete(" ");
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
                        string _nameOfGoal = g.ToString();
                        _counter += 1;
                        
                        if (_nameOfGoal == "ChecklistGoals")
                        {
                            Console.Write($"{_counter}. [{g.GetComplete()}] {g.GetName()} ({g.GetDescription()})");
                            Console.WriteLine($" -- Currently completed: {g.GetChecklistTimes()}/{g.GetTimes()}");
                        }
                        else
                        {
                            Console.WriteLine($"{_counter}. [{g.GetComplete()}] {g.GetName()} ({g.GetDescription()})");
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
                        outputFile.WriteLine(totalPoints);
                        foreach (Goals g in goals)
                        {
                            string saveGoals = GetStringRepresentation(g);
                            outputFile.WriteLine(saveGoals);
                        }
                    }

                    break;

                //Load Goals
                case "4":
                    //Ask the user for the file to load
                    
                    
                    break;

                //Record Event
                case "5":
                    DisplayGoals(goals);
                    int _accomplished = GoalAccomplished(goals);
                    totalPoints += _accomplished;
                    int _accomplishedBonus = GoalBonus(goals);
                    Console.WriteLine($"Congratulations! You have earned {_accomplished + _accomplishedBonus} points!");
                    totalPoints += _accomplishedBonus;
                    Console.WriteLine($"You now have {totalPoints} points.");
                    break;

                //Quit Program
                case "6":
                    exitProgram = true;
                break;

                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }
}