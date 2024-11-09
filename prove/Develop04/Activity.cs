using System;
using System.Security.Cryptography;


class Activity
{
    protected string startMessage;
    protected string endMessage;
    protected string bodyMessage;
    protected string title;
    protected int duration;

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public Activity(string _title)
    {
        title = _title;
        startMessage = $"\nWelcome to the {title}";
        

    }
    

    public void GetDuration()
    {
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();      
        duration = int.Parse(durationString);
        endMessage = $"Well done. \nYou have completed the {title} that lasted for {duration} seconds. ";

    }

    public void GetReady(string message)
    {
        Animation animation = new Animation();
        Console.WriteLine("\nGet ready.");
        animation.Countdown(3);
    }
}