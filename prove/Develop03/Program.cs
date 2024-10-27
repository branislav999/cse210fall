using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool choice = true;

        Scripture scripture = new Scripture();
        scripture.Load();
        scripture.Display();

        while(choice)
        {
        Console.WriteLine("\nPress enter to hide words. Type 'quit' to quit.");
        string input = Console.ReadLine();
        Console.Clear();

        switch(input)
        {
            case "":
                scripture.HideWords();
                Console.Clear(); 
                scripture.Display();

                if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("\nApply that Scripture in your life! ");
                        choice = false;
                    }
                break; 
                

            case "quit":
                choice = false;
                break;
        }        
        }   
    
    
    
    }
}