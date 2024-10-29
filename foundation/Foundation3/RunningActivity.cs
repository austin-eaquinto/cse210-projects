using System;

class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int duration, double distance, int time) : base ("Running", duration, time)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {   // allows for to get the value from the main program parameter
        return _distance;
    }
    // the maths below
    public override double GetSpeed()
    {
        return (_distance / GetLengthOfActivity()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthOfActivity() / _distance;
    }
    public override string GetSummary()
    {   // one of the iterated summaries
        return $"{base.GetSummary()} Distance: {_distance} miles {GetSpeed()} mph Pace of {GetPace()} minutes per mile";
    }
}