using System;

abstract class Goal
{
    private string _name;
    protected string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {   // updates if the event has been done

    }
    public virtual bool IsComplete()
    {
        return true;
    }
    public virtual string GetDetailsString()
    {
        return $"Goal/{_name}/{_description}/{_points}";
    }
    public abstract string GetStringRepresentation();
}