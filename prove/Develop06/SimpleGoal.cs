using System;

class SimpleGoal : Goal
{
    private bool _isComplete;
    // private string _name;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // _name = name;
        _isComplete = false; // initializes to false
    }
    public override void RecordEvent()
    {  
        _isComplete = true; // as in, it will record the event
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string checkBox = ""; // initializes the string value
        if (_isComplete) // returns either option based on the true or false return
        {
            checkBox = "[X]";
        }
        else
        {
            checkBox = "[ ]";
        }
        return $"{checkBox}: {GetDetailsString()}";
        // string goalStatus = _isComplete ? "[X]" : "[ ]";
        // return $"{foalStatus}: {GetDetailsString()};
    }
}