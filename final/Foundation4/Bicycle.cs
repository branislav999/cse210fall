using System;

public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Bicycle - Speed: {GetSpeed():F2} mph";
    }
}
