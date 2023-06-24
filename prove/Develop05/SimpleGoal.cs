using System;
class SimpleGoal : Goal
{
    private string _goalPoints;
    private string _goalType = "Simple Goal";
    
    public SimpleGoal(string goalName, string goalDescription, string goalPoints) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
    }

    public override string GetGoalInfo()
    {
        return $"{GetGoalName()} ({GetGoalDescription()})";
    }

    public override int GetPoints()
    {
        return int.Parse(_goalPoints);
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation! You have earned {_goalPoints} points!");
    }

    public override bool IsComplete()
    {
        return true;
    }
}