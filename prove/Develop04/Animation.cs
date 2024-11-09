using System;


class Animation
{
    private List<string> characters = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };    
        

    public void Countdown(int numberSeconds)
    {
        for (int i = numberSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Dots(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void Rotation(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(characters[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= characters.Count)
            {
                i = 0;
            }
        }

    }
}