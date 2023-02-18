using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;

        //Menu options
        static string UserChoice()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            return choice;
        }

        while(!exitProgram)
        {
            string choiceSelected = UserChoice();

            //Take user option and execute
            switch(choiceSelected)
            {
                //Breathing Activity
                case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayBreathingActivity();

                break;

                //Reflecting Activity
                case "2":


                break;

                //Listing Activity
                case "3":


                break;

                //Quit Program
                case "4":
                    exitProgram = true;
                break;

                //Error handling
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;

            }
        }
    }
}