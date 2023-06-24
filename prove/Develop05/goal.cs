public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _defaultPoints;
    
    public Goal(string goalName, string goalDescription)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    
    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public int GetDefaultPoints()
    {
        return _defaultPoints;
    }

    public void SetDefaultPoints(int defaultPoints)
    {
        _defaultPoints = defaultPoints;
    }

    public abstract string GetGoalInfo();

    public abstract int GetPoints();

    public abstract void RecordEvent();

    public abstract bool IsComplete();
}