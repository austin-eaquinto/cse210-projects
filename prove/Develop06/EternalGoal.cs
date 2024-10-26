using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        // empty because it will never be checked off
    }
    public override bool IsComplete()
    {
        return false; // because this is the 'eternal' goal, it will never be complete
    }
    public override string GetStringRepresentation()
    {
        string goalDescription = "[ ]"; // because it will never be complete
        return $"{goalDescription}: {GetDetailsString()}";
    }
}