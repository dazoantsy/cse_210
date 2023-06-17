public class Activity
{
    //private string _date;
    private string _startingMessage;
    private string _endingMessage;
    //private string _activityDescription;
    private int _duration;

    public Activity()
    {
        /*_startingMessage = startingMessage;
        _activityDescription = activityDescription;*/  
    }

    
    public string GetStartingMessage()
    {
        return _startingMessage;
    }
    public void SetStartingMessage(string activityName, string activityDescription)
    {
        _startingMessage = $"Welcome to the {activityName}.\n\nThis activity will help you {activityDescription}\n\n" + 
        "How long, in seconds, would you like for your session?\n";
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }
    public void SetEndingMessage(int duration, string activityName)
    {
        _duration = duration;
        _endingMessage = $"You have completed another {_duration} seconds of the {activityName}";
    }

    public void Pause(int duration)
    {
        _duration = duration;
        while (duration != 0)
        {
            Console.Write(duration.ToString());

            Thread.Sleep(1000);

            Console.Write("\b \b"); // Erase the + character
            //Console.Write(duration.ToString()); // Replace it with the - character
            duration --;
        }
    }

    public void Spin(string spinMessage, int spinDuration)
    {
        Console.WriteLine(spinMessage);
        while (spinDuration != 0)
        {
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep (250);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Thread.Sleep(250);
            spinDuration --;
        }
    }
}