using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {   // if your are recording the event and the amount completed is less than the target goal
        if (_amountCompleted < _target)  
        {
            _amountCompleted ++; // then add to the amount
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    { // 
        return $"{_amountCompleted}/{_target}";
    }
        // Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        // _target = Int32.Parse(Console.ReadLine());
        // Console.Write("What is the bonus for completing it that many times? ");
        // _bonus = Int32.Parse(Console.ReadLine());
    public override string GetStringRepresentation()
    {
        string goalDescription = ""; // initializes the string value
        if (_amountCompleted < _target) // returns either option based on the true or false return
        {
            goalDescription = "[ ]";
        }
        else
        {
            goalDescription = "[X]";
        }
        return $"{goalDescription}: {GetDetailsString()}";
    }
}