using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_durationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}
