using System;
public class ChecklistGoal : Goal
{
    private string _goalPoints, _bonusPoint, _expectedAccomplishment;
    private int _accomplishmentNumber;
    
    public ChecklistGoal(string goalName, string goalDescription, string goalPoints, string expectedAccomplishment, string bonusPoints, int accomplishmentNumber) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _bonusPoint = bonusPoints;
        _expectedAccomplishment = expectedAccomplishment;
        _accomplishmentNumber = accomplishmentNumber;
    }

    public override string GetGoalInfo()
    {
        return $"{GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_accomplishmentNumber}/{_expectedAccomplishment}";
    }

    public override int GetPoints()
    {
        if (_accomplishmentNumber >= int.Parse(_expectedAccomplishment))
        {
            return int.Parse(_goalPoints) + int.Parse(_bonusPoint);
        }
        else
        {
            return int.Parse(_goalPoints);
        }
    }

    public override void RecordEvent(int totalPoints)
    {
        if (_accomplishmentNumber >= int.Parse(_expectedAccomplishment))
        {
            Console.WriteLine($"Congratulation! You have earned {_goalPoints} points and a bonus of {_bonusPoint} points!");
            Console.WriteLine($"You now have {totalPoints} points.");
        }
        else
        {
            Console.WriteLine($"Congratulation! You have earned {_goalPoints} points!");
            Console.WriteLine($"You now have {totalPoints} points.");
        }
    }

    public override bool IsComplete()
    {
        if (_accomplishmentNumber >= int.Parse(_expectedAccomplishment))
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