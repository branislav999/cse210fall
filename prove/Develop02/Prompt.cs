public class Prompt{

    //menu options
    string _menu = "Choose an option\n \n1.Write a new entry\n2.Display the journal\n3.Save the journal to a file\n4.Load the journal from a file\n5.Exit";


    //display menu
    public void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine(_menu);
    }


    //list for the prompts
    public List<string> _prompts = new List<string>(){
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be? ", 
        "What is the most important lesson I have learned today? ",
        "What made me smile or laugh today? "
    };

  


    //get a random prompt from the _prompts list
    public string GetPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    

    
}