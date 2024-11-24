using System;

public class Method
{
    List<Base> _goals = new List<Base>();
    private int _totalPoints;

    public void CreateNewGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the type of goal (1-3): ");
        int _type = int.Parse(Console.ReadLine());

        if (_type == 1)
        {
            Base _simpleGoal = new SimpleGoal();
            _simpleGoal.GetInput();
            _goals.Add(_simpleGoal);
        }
        else if (_type == 2)
        {
            Base _eternalGoal = new EternalGoal();
            _eternalGoal.GetInput();
            _goals.Add(_eternalGoal);
        }
        else
        {
            Base _checklistGoal = new ChecklistGoal();
            _checklistGoal.GetInput();
            _goals.Add(_checklistGoal);
        }
    }

    public void Save()
    {
        Console.WriteLine("\nEnter the name of the file: ");
        string _fileName = Console.ReadLine();
        using (StreamWriter _outputFile = new StreamWriter(_fileName))
        {
            _outputFile.WriteLine(_totalPoints);

            foreach (Base _goal in _goals)
            {
                _outputFile.WriteLine(_goal.GetSaveText());
            }
        }
    }

    public void Load()
    {
        _goals.Clear();

        Console.WriteLine("\nWhat is the name of the file: ");
        string _filename = Console.ReadLine();
        string[] _lines = System.IO.File.ReadAllLines(_filename);

        if (_lines.Length > 0)
        {
            string _firstLine = _lines[0];
            int _loadedPoints = int.Parse(_firstLine);
            _totalPoints = _loadedPoints;

            for (int i = 1; i < _lines.Length; i++)
            {
                string[] _parts = _lines[i].Split("~");

                string _goalType = _parts[0];
                string _checkmark = _parts[1];
                string _goalTitle = _parts[2];
                string _goalDescription = _parts[3];
                int _points = int.Parse(_parts[4]);
                int _bonusPoints = 0;
                int _accomplished = 0;
                int _desired = 0;

                if (_goalType == "Checklist Goal:")
                {
                    _accomplished = int.Parse(_parts[5]);
                    _desired = int.Parse(_parts[6]);
                    _bonusPoints = int.Parse(_parts[7]);
                }

                switch (_goalType)
                {
                    case "Simple Goal:":
                        SimpleGoal _simple = new SimpleGoal();
                        _simple.SetTitle(_goalTitle);
                        _simple.SetDescription(_goalDescription);
                        _simple.SetPoints(_points);
                        _goals.Add(_simple);
                        break;

                    case "Eternal Goal:":
                        EternalGoal _eternal = new EternalGoal();
                        _eternal.SetTitle(_goalTitle);
                        _eternal.SetDescription(_goalDescription);
                        _eternal.SetPoints(_points);
                        _goals.Add(_eternal);
                        break;

                    case "Checklist Goal:":
                        ChecklistGoal _checklist = new ChecklistGoal();
                        _checklist.SetTitle(_goalTitle);
                        _checklist.SetDescription(_goalDescription);
                        _checklist.SetPoints(_points);
                        _checklist.SetBonusPoints(_bonusPoints);
                        _checklist.SetAccomplished(_accomplished);
                        _checklist.SetDesired(_desired);
                        _goals.Add(_checklist);
                        break;
                }
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayText()}");
        }

        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayText()}");
        }

        Console.Write("\nWhich goal did you accomplish (enter the goal number): ");
        int _goalNumber = int.Parse(Console.ReadLine());

        Base _goal = _goals[_goalNumber - 1];

        if (_goal.IsCompleted())
        {
            Console.WriteLine("\nThe goal is already completed.");
        }
        else
        {
            _goal.Completed();

            _totalPoints += _goal.GetPoints();
            Console.WriteLine($"\nCongratulations, you have earned {_goal.GetPoints()} points.");
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
    }

    public void Edit()
    {
        Console.WriteLine("Edit Goals:");
        Console.WriteLine("   1. Edit Title");
        Console.WriteLine("   2. Edit Description");
        Console.WriteLine("   3. Edit Points");
        Console.WriteLine("   4. Cancel");

        Console.Write("Enter your choice: ");
        int _choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Select a goal to edit:");
        ListGoals();

        Console.Write("Enter the goal number to edit: ");
        int _goalNumber = int.Parse(Console.ReadLine());

        Base _goal = _goals[_goalNumber - 1];

        switch (_choice)
        {
            case 1:
                Console.Write("Enter the new title: ");
                _goal.SetTitle(Console.ReadLine());
                break;
            case 2:
                Console.Write("Enter the new description: ");
                _goal.SetDescription(Console.ReadLine());
                break;
            case 3:
                Console.Write("Enter the new points: ");
                _goal.SetPoints(int.Parse(Console.ReadLine()));
                break;
        }

        Console.WriteLine("\nThis is the updated goal: ");
        Console.WriteLine(_goal.GetDisplayText());
    }
}
