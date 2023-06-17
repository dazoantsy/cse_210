using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
	private string _activityDescription;
    private string _activityName;
	private int _duration;
    public BreathingActivity(string activityName, string activityDescription) : base()
	{
		_activityName = activityName;
        _activityDescription = activityDescription;
        base.SetStartingMessage(_activityName, _activityDescription);
	}
	public void Breathe(int duration)
	{
		_duration = duration;
		int sessionDuration = _duration / 10;
		while (sessionDuration != 0)
		{
			Console.Write("Breathe in through your nose ...");
			base.Pause(4);
			Console.Write("\n");
			Console.Write("Breathe out through your mouth ...");
			base.Pause(6);
			Console.Write("\n\n");
			sessionDuration --;
		}
		base.SetEndingMessage(duration, _activityName);
	}
}