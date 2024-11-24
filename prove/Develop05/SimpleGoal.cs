public class SimpleGoal : Base
{
    private bool _completed = false;

    public override string GetSaveText()
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
        return $"Simple Goal:~{_isCompleted}~{_goalTitle}~{_goalDescription}~{_points}";
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
        return $"Simple Goal: {_isCompleted} {_goalTitle} ({_goalDescription}). You get {_points} points for doing this goal. ";
    }

    public override void Completed()
    {
        _completed = true;
    }

    public override bool IsCompleted()
    {
        return _completed;
    }
}
