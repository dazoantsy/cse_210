using System;
class SimpleGoal : Goal
{
    private string _goalPoints;
    int _accomplishmentNumber;

    public SimpleGoal(string goalName, string goalDescription, string goalPoints, int accomplishmentNumber) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _accomplishmentNumber = accomplishmentNumber;
    }

    public override string GetGoalInfo()
    {
        return $"{GetGoalName()} ({GetGoalDescription()})";
    }

    public override void RecordEvent(int totalPoints)
    {
        Console.WriteLine($"Congratulation! You have earned {_goalPoints} points!");
        Console.WriteLine($"You now have {totalPoints} points.");
    }

    public override int GetPoints()
    {
        return int.Parse(_goalPoints);
    }

    public override bool IsComplete()
    {
        if (_accomplishmentNumber >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetGoalStatus()
    {
        if (IsComplete() == true)
        {
            return "[X]";
        }
        else{
            return "[ ]";
        }
    }
}