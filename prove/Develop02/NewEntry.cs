using System;

public class NewEntry
{
    public string _prompt = "";

    public string _response = "";

    public string _date = DateTime.Now.ToString("MM-dd-yyyy");

    public void DisplayNewEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        //Example print display:
        //Date: 01/24/2023 - Prompt: What was something that made you smile today?
        //Response: I smiled when my dog sat on my lap.
    }
}