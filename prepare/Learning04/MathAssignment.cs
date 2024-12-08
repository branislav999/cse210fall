using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base("Branislav Bogosavac", "Fractions")
    {
        _textbookSection = "3";
        _problems = "14-19";
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}";
    }

}