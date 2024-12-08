
using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base ("Branislav Bogosavac", "Ancient Greek")
    {
        _title = "Alexander the Great";
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} \n{_title}";
    }
    
}
