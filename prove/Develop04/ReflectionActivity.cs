using System;

public class ReflectionActivity : Activity
{
    private string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _activityName = "Reflection Activity";
    private int _seconds = 30;
    private string _prompt = "";

    List<string> promptList = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> questionList = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void DisplayReflectionActivity()
    {
        GetStartingMessage(_activityName, _activityDescription);
        Console.WriteLine("How long, in increments of 10 seconds, would you like for your session?");
        string _secondsInputted = Console.ReadLine();
        int _theseSeconds = int.Parse(_secondsInputted);
        _seconds = GetSeconds(_theseSeconds);
        GetReady();        
        //specific inner workings of Reflection Activity go here
        DisplayThinkDeeply();
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void DisplayThinkDeeply()
    {
        Random random = new Random();
        int num = random.Next(0,3);
        //Prompt prompt = new Prompt();
        _prompt = promptList[num];
        Console.WriteLine(_prompt);
    }
}