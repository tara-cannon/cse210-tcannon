using System;

public class ReflectionActivity : Activity
{
    private string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _activityName = "Reflection Activity";
    private string _prompt = "";
    private string _question = "";

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
        GetActivityDisplay(_activityName, _activityDescription);
        DisplayThinkDeeply();
        GetEndingMessage(_secondsInputted, _activityName);
    }

    public void DisplayThinkDeeply()
    {
        Random random = new Random();
        int promptNum = random.Next(0,3);
        _prompt = promptList[promptNum];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string response = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:");
        GetCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_theseSeconds);  
        int _remainingTime = _theseSeconds * 2;

        while (DateTime.Now < futureTime)
        {
            int questionNum = random.Next(0,8);
            _question = questionList[questionNum];

            Console.WriteLine($"> {_question}");            

            if (_theseSeconds * 2 > 20)
            {
                _remainingTime = 20;
                _theseSeconds -= 10;
            }
            else
            {
                _remainingTime = _theseSeconds * 2;
            }

            GetSpinner(_remainingTime);
        }
    }
}