using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Base
{
    private int _bonusPoints;
    private int _accomplished;
    private int _desired;
    private bool _completed = false;

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public void SetAccomplished(int accomplished)
    {
        _accomplished = accomplished;
    }

    public void SetDesired(int desired)
    {
        _desired = desired;
    }

    public override void GetInput()
    {
        base.GetInput();
        Console.WriteLine("Enter the desired number of times to accomplish the goal: ");
        _desired = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter bonus points for accomplishing the goal {_desired} number of times: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override string GetSaveText()
    {
        string _isCompleted;
        if (_completed)
        {
            _isCompleted = "[X]";
        }
        else
        {
            _isCompleted = "[ ]";
        }

        return $"Checklist Goal:~{_isCompleted}~{_goalTitle}~{_goalDescription}~{_points}~{_accomplished}~{_desired}~{_bonusPoints}";
    }

    public override string GetDisplayText()
    {
        string _isCompleted;

        if (_completed)
        {
            _isCompleted = "[x]";
        }
        else
        {
            _isCompleted = "[ ]";
        }
        return $"Checklist Goal: {_isCompleted} {_goalTitle} ({_goalDescription}) You get {_points} points for doing the goal. --Completed {_accomplished}/{_desired} times. You get {_bonusPoints} after completing it.";
    }

    public override void Completed()
    {
        _accomplished++;

        if (_accomplished == _desired)
        {
            _completed = true;
        }
    }

    public override int GetPoints()
    {
        if (_completed)
        {        
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsCompleted()
    {
        return _completed;
    }
}
