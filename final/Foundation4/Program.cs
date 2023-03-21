using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running();
        running.SetTodaysDate("03 Mar 2023");
        running.SetMinutes(30);
        running.SetMiles(5);
        activities.Add(running);

        Cycling cycling = new Cycling();
        cycling.SetTodaysDate("15 Feb 2023");
        cycling.SetMinutes(30);
        cycling.SetMiles(20);
        activities.Add(cycling);

        Swimming swimming = new Swimming();
        swimming.SetTodaysDate("20 Jan 2023");
        swimming.SetMinutes(10);
        swimming.SetLaps(8);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            string _summary = a.GetSummary(a.ToString());
            double _howFar = a.CalculateDistance();
            double _fast = a.CalculateSpeed(_howFar);
            double _average = a.CalculatePace(_howFar);

            Console.WriteLine($"{_summary} - Distance {_howFar} miles, Speed {_fast} mph, Pace {_average} min per mile");       
        }
        
    }
}