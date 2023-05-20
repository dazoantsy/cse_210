using System;

public class PromptGenerator
{
    public static string[] _promptList = {
        "If I had one thing I could do over today, what would it be?",
        "What steps did you take today towards a goal I set?",
        "What are the things I'm grateful for today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What have I learned from my scripture study today?",
        "One thing that I want to remember from today?",
        "What went well today?",
        "How can I make tomorrow better than today?",
        "Who did I meet today that inspired me?",
    };

    public List<string> _prompt = new List<string>(_promptList);

    public PromptGenerator()
    {
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string journalPrompt = _prompt[index];
        Console.WriteLine($"\n{_prompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string journalPrompt = _prompt[index];
        return journalPrompt;
    }
}