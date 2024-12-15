using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_durationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _durationInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {_distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}
