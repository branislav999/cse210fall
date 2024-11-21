using System;
using System.IO;

public abstract class Base
{
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _points;
    

    public void SetTitle(string goalTitle)
    {
        _goalTitle = goalTitle;
    }

    public void SetDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public virtual bool IsCompleted()
    {
        return false;
    }
    
    public virtual void GetInput()
    {
        Console.WriteLine("Enter the goal title: ");
        _goalTitle = Console.ReadLine();
        Console.WriteLine("Enter the goal description: ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("Enter points for achieving the goal: ");
        _points = int.Parse(Console.ReadLine());
    }
    
       
    public abstract string GetSaveText();
    public abstract string GetDisplayText();


    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual void Completed()
    {

    }



}