using System;

class SwimmingActivity : Activity
{
    private int _lapAmount;

    public SwimmingActivity(int duration, int lapAmount, int time) : base("Swimming", duration, time)
    {
        _lapAmount = lapAmount;
    }
    // the maths below
    public override double GetDistance()
    {   // different from the other two because once the _lapAmount is got,
        // it has to be mathed in.
        double lapDistance = _lapAmount * 50 / 1000;
        return lapDistance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLengthOfActivity() * 60;
    }
    public override double GetPace()
    {
        return GetLengthOfActivity() / GetDistance();
    }
    public override string GetSummary()
    {   // one of the iterated summaries
        return $"{base.GetSummary()} Distance: {GetDistance()} miles {GetSpeed()} mph Pace of {GetPace()} minutes per mile";
    }

}