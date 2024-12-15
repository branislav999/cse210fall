using System;

public class Activity
{
    private string _date;
    protected int _durationInMinutes;

    public Activity(string date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{_date} (Duration: {_durationInMinutes} min)";
    }
}
