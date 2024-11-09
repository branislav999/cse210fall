using System;

class Listing : Activity
{

    private List<string> prompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    public Listing() : base("Reflection Activity")
    {
        bodyMessage =  "\nThis activity will help you reflect on the good things in life and by having you list as many things as you can in a certain area.";
    }

    public void StartListingActivity()
    {
        DisplayMessage(startMessage);
        DisplayMessage(bodyMessage);
        GetDuration();
        GetReady("");

        Random random = new Random();
        int randomPromptIndex = random.Next(0, prompts.Count);
        Console.WriteLine(prompts[randomPromptIndex]);

        Animation animation = new Animation();

        Console.Write("You may begin in: ");
        Console.WriteLine("");
        animation.Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.WriteLine("");
        DisplayMessage(endMessage);







        
    }




}