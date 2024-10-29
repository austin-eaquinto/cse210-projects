using System;

abstract class Activity
{
    private int _duration;
    private double _distance;
    private double _speed;
    private string _name;
    private int _time;

    public Activity(string name, int duration, int time)
    {   // constructor for the base class
        _duration = duration;
        _name = name;
        _time = time;
    }
    public string GetDateTime()
    {   // simple enough
        DateTime dateAndTime = DateTime.Today;
        return dateAndTime.ToShortDateString();
    }

    // in the following section each "Get..." returns the placeholder thing
    // for to enter the value in the main program constructor parameters
    public virtual int GetLengthOfActivity()
    {
        return _duration;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetTime()
    {
        return _time;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{GetDateTime()} ({_time} minutes) {_name} Activity: {_duration} min";
    }
}