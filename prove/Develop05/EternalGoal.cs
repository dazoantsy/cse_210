using System;
class EternalGoal : Goal
{
    private string _goalPoints;
    private string _goalType = "Eternal Goal";
    
    public EternalGoal(string goalName, string goalDescription, string goalPoints) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
    }

    public override string GetGoalInfo()
    {
        return $"{GetGoalName()} ({GetGoalDescription()})";
    }

    public override int GetPoints()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return false;
    }
}