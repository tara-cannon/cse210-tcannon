using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment3 = new Assignment();
        assignment3.SetStudentName("Tara");
        assignment3.SetTopic("Yoga");

        Console.WriteLine(assignment3.GetSummary());

        MathAssignment assignment1 = new MathAssignment();
        assignment1.SetStudentName("Tara");
        assignment1.SetTopic("Math");
        assignment1.SetTextBookSection("7.3");
        assignment1.SetProblems("8-19");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment();
        assignment2.SetStudentName("Tara");
        assignment2.SetTopic("English");
        assignment2.SetTitle("The Great Gatsby");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}