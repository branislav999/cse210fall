using System;

public class Method
{
    List<Base> goals = new List<Base>();
    private int totalPoints;


    public void CreateNewGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the type of goal (1-3): ");
        int type = int.Parse(Console.ReadLine());

        


        if (type == 1)
        {
            Base simpleGoal = new SimpleGoal();
            simpleGoal.GetInput();
            goals.Add(simpleGoal);
        }
        else if (type == 2)
        {
            Base eternalGoal = new EternalGoal();
            eternalGoal.GetInput();
            goals.Add(eternalGoal);
        }
        else
        {
            Base checklistGoal = new ChecklistGoal();
            checklistGoal.GetInput();
            goals.Add(checklistGoal);
        }
        
    }
    public void Save()
    {
        Console.WriteLine("\nEnter the name of the file: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);

            foreach (Base goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveText());
            }            
            
        }
    }
    
public void Load()
    {
        goals.Clear();

        Console.WriteLine("\nWhat is the name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);


        if (lines.Length > 0)
        {
            string first_line = lines[0];
            int loadedPoints = int.Parse(first_line);
            totalPoints = loadedPoints;


        for (int i = 1; i < lines.Length; i++)
        {

            string[] parts = lines[i].Split("~");


            string goalType = parts[0];
            string checkmark = parts[1];
            string goalTitle = parts[2];
            string goalDescription = parts[3];
            int points = int.Parse(parts[4]);
            int bonusPoints = 0;
            int accomplished = 0;
            int desired = 0;

            if (goalType == "Checklist Goal:")
            {
                accomplished = int.Parse(parts[5]);
                desired = int.Parse(parts[6]);
                bonusPoints = int.Parse(parts[7]);               
            }

            

            switch (goalType)
            {
                case "Simple Goal:":
                    SimpleGoal simple = new SimpleGoal();
                    simple.SetTitle(goalTitle);
                    simple.SetDescription(goalDescription);
                    simple.SetPoints(points);
                    goals.Add(simple);
                    break;
                
                case "Eternal Goal:":
                    EternalGoal eternal = new EternalGoal();
                    eternal.SetTitle(goalTitle);
                    eternal.SetDescription(goalDescription);
                    eternal.SetPoints(points);
                    goals.Add(eternal);
                    break;
                
                
                case "Checklist Goal:":
                    ChecklistGoal checklist = new ChecklistGoal();
                    checklist.SetTitle(goalTitle);
                    checklist.SetDescription(goalDescription);
                    checklist.SetPoints(points);
                    checklist.SetBonusPoints(bonusPoints);
                    checklist.SetAccomplished(accomplished);
                    checklist.SetDesired(desired);
                    goals.Add(checklist);
                    break;
                    

            }
        }
        }
    }


    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayText()}");
        }

        Console.WriteLine($"You have {totalPoints} points.");
    }

    public void RecordEvent()
    {

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayText()}");
        }

        Console.Write("\nWhich goal did you accomplish (enter the goal number): ");
        int goalNumber = int.Parse(Console.ReadLine());

        
        Base goal = goals[goalNumber - 1];

        if (goal.IsCompleted())
        {
            Console.WriteLine("\nThe goal is already completed.");
        }
        else
        {
            goal.Completed();

            totalPoints += goal.GetPoints();
            Console.WriteLine($"\nCongratulations, you have earned {goal.GetPoints()} points.");
            Console.WriteLine($"You now have {totalPoints} points.");
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
    int choice = int.Parse(Console.ReadLine());

    Console.WriteLine("Select a goal to edit:");
    ListGoals(); 

    Console.Write("Enter the goal number to edit: ");
    int goalNumber = int.Parse(Console.ReadLine());

    
    {
        Base goal = goals[goalNumber - 1];

        switch (choice)
        {
            case 1:
                Console.Write("Enter the new title: ");
                goal.SetTitle(Console.ReadLine());
                break;
            case 2:
                Console.Write("Enter the new description: ");
                goal.SetDescription(Console.ReadLine());
                break;
            case 3:
                Console.Write("Enter the new points: ");
                goal.SetPoints(int.Parse(Console.ReadLine()));
                break;
            
        }

        Console.WriteLine("\nThis is the updated goal: ");
        Console.WriteLine(goal.GetDisplayText());
    }
    }

}