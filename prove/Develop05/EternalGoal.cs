using System;
class EternalGoal : Goal
{
    private string _goalPoints;
    
    public EternalGoal(string goalName, string goalDescription, string goalPoints) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
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
        return false;
    }

    public override string GetGoalStatus()
    {
        return "[ ]";
    }
}