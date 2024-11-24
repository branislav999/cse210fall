public class EternalGoal : Base
{
   
    public override string GetSaveText()
    {
        
        return $"Eternal Goal:~[ ]~{_goalTitle}~{_goalDescription}~{_points}";
    }

    public override string GetDisplayText()
    {
        return $"Eternal Goal: [ ] {_goalTitle} ({_goalDescription}). You get {_points} points for doing this goal. ";
    }
}
