using System;

class Reflection : Activity
{
    private List<int> indexTracker = new List<int>{};
    public Reflection() : base("Reflection Activity")
    {
    bodyMessage = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void StartReflectionActivity()
    {
        Animation animation = new Animation();

        DisplayMessage(startMessage);
        DisplayMessage(bodyMessage);
        GetDuration();
        GetReady("");

        Console.WriteLine("\nConsider the following prompt. ");

        string[] prompts = System.IO.File.ReadAllLines("prompt.csv");

        Random random = new Random();
        int randomPromptIndex = random.Next(0, prompts.Length);

        string randomPrompt = prompts[randomPromptIndex];

        Console.WriteLine(randomPrompt);
        Console.WriteLine("\nWhen you have something in mind press start typing: ");
        string response = Console.ReadLine();
        Console.WriteLine("Now, think about the following questions about the experience\n");

        string[] reflections = System.IO.File.ReadAllLines("reflection.csv");


        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        
        while (DateTime.Now < endTime)  
        {
            int randomReflectionIndex;

            do
            {
                randomReflectionIndex = random.Next(0, reflections.Length);
            } while (indexTracker.Contains(randomReflectionIndex));
            indexTracker.Add(randomReflectionIndex);


            Console.WriteLine($"--{reflections[randomReflectionIndex]}--\n");
            animation.Rotation(5);
                    
        }

        DisplayMessage(endMessage);

    }

}