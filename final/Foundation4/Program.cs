using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> _activities = new List<Activity>();

        
        Running _runningActivity = new Running("11/10/2023", 30, 3.0);
        Bicycle _bicycleActivity = new Bicycle("11/10/2023", 30, 15.0);
        Swimming _swimmingActivity = new Swimming("11/10/2023", 30, 10);

        
        _activities.Add(_runningActivity);
        _activities.Add(_bicycleActivity);
        _activities.Add(_swimmingActivity);

        
        foreach (var _activity in _activities)
        {
            Console.WriteLine(_activity.GetSummary());
        }
    }
}
