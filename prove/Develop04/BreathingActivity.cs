using System;

class Breathing : Activity
{
    private string breatheIn = "\nBreathe in...";
    private string breatheOut = "\nBreathe out...";

    public Breathing () : base("Breathing Activity")
    {
        bodyMessage = "\nThis Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


    public void StartBreathingActivity()
    {
        Animation animation = new Animation();

        DisplayMessage(startMessage);
        DisplayMessage(bodyMessage);
        GetDuration();
        GetReady("Clear your mind and focus on your breathing.");

        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(breatheIn);
            animation.Countdown(5);

            Console.Write(breatheOut);
            animation.Countdown(5);                 
            
        }

        DisplayMessage(endMessage);
        animation.Rotation(5);


    }

}