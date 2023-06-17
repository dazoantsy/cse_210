using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private string _activityDescription;
    private string _activityName;
    
    private static string[] _promptList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _prompts = new List<string>(_promptList);

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public ListingActivity(string activityName, string activityDescription) : base()
	{
		_activityName = activityName;
        _activityDescription = activityDescription;
        base.SetStartingMessage(_activityName, _activityDescription);
	}

    public void Listing(int duration)
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
		Console.WriteLine($"--- {GetPrompt()} ---\n");
        Console.WriteLine("You may begin in ");
        base.Pause(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (endTime > startTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            startTime = DateTime.Now;
        }
        
    }
}