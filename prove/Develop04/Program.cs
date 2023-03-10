using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;

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

            switch(choiceSelected)
            {
                case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayBreathingActivity();

                break;

                case "2":
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DisplayReflectionActivity();

                break;

                case "3":
                ListingActivity listing = new ListingActivity();
                listing.DisplayListingActivity();

                break;

                case "4":
                    exitProgram = true;
                break;

                //Exceeding Requirements: Error handling
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;

            }
        }
    }
}