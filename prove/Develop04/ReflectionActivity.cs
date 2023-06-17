using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private string _activityDescription;
    private string _activityName;
    
    private static string[] _promptList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] _questionList = {
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

    private List<string> _prompts = new List<string>(_promptList);
    private List<string> _questions = new List<string>(_questionList);

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetQuestion()
    {
        var random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public ReflectionActivity(string activityName, string activityDescription) : base()
	{
		_activityName = activityName;
        _activityDescription = activityDescription;
        base.SetStartingMessage(_activityName, _activityDescription);
	}

    public void Reflect(int duration)
    {
        int reflectionTime = 15;
        if (duration < reflectionTime)
        {
            Console.WriteLine("Time too short to do a reflection");
        }
        else
        {
            int numberOfQuestion = duration / reflectionTime;

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in ");
            base.Pause(5);
            Console.Clear();
            while (numberOfQuestion != 0)
            {
                base.Spin(GetQuestion(), reflectionTime);
                numberOfQuestion --;
            }
            }
    }
}