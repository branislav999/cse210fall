using System;
using System.Globalization;

class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double number = _top/_bottom;
        return number;
    }

    
}