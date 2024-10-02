using System;

public class Fraction
{
    // private variables are only used in this class,
    // not accessed by any other class.
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        // i think this becomes the default value if for 
        // example, in the Program class, the instance of
        // f5 no parameters are given in the Fraction and
        // it returns 1 and 1/1.
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        // the top will be an entered value
        // bottom is always 1.
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        // top and bottom will be entered values
        _topNumber = top;
        _bottomNumber = bottom;
    }
    public string DisplayMath()
    {
        // simply displays as a fraction. does not
        // do math.
        return $"{_topNumber}/{_bottomNumber}";
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }
    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}