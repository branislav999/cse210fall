public class SimpleGoal : Base
{
    private bool _completed = false;

    
    public override string GetSaveText()
    {
        string isCompleted;

        if (_completed)
        {
            isCompleted = "[x]";
        }
        else
        {
            isCompleted = "[ ]";
        }
        return $"Simple Goal:~{isCompleted}~{_goalTitle}~{_goalDescription}~{_points}";
    }

    public override string GetDisplayText()
    {
        string isCompleted;

        if (_completed)
        {
            isCompleted = "[x]";
        }
        else
        {
            isCompleted = "[ ]";
        }
        return $"Simple Goal: {isCompleted} {_goalTitle} ({_goalDescription}). You get {_points} points for doing this goal. ";
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