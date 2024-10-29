using System;

class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(int duration, double speed, int time) : base("Biking", duration, time)
    {
        _speed = speed;
    }
    // the maths below
    public override double GetDistance()
    {
        return (_speed * GetLengthOfActivity()) / 60;
    }
    public override double GetSpeed()
    {   // allows for to get the value from the main program parameter
        return _speed;
    }
        public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {   // one of the iterated summaries
        return $"{base.GetSummary()} Distance: {GetDistance()} miles {GetSpeed()} mph Pace of {GetPace()} minutes per mile";
    }
}