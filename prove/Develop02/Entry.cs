using System;
using System.IO;

public class Entry 
{

   string _date;
   string _prompt;
   string _response;

   public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

    }

   public string GetText()
   {
        return $"{_date}~{_prompt}~{_response}";        
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} - Response: {_response}");
    }

}