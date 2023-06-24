using System;
public class ChecklistGoal : Goal
{
    private string _goalPoints, _accomplishmentNumber, _bonusPoint;
    private string _goalType = "Simple Goal";
    
    public ChecklistGoal(string goalName, string goalDescription, string goalPoints, string accomplishmentNumber, string bonusPoints) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _accomplishmentNumber = accomplishmentNumber;
        _bonusPoint = bonusPoints;
    }

    public override string GetGoalInfo()
    {
        return $"{GetGoalName()} ({GetGoalDescription()}) -- Currently completed: /{_accomplishmentNumber}";
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
        throw new NotImplementedException();
    }
}