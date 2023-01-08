using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please enter grade percentage: ");
        string userPercentage = Console.ReadLine();

        int x = int.Parse(userPercentage);

        if (x >= 90)
        {
            Console.WriteLine("A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You are passing your class.");
        }
        else
        {
            Console.WriteLine("Try harder next time.");
        }

    }
}