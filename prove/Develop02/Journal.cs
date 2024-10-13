
using System;
using System.IO;

public class Journal 
{

    //list that stores user's inputs
    public List<Entry> entries = new List<Entry>();

    //storing the input in the list
    public void Write()
    {
        Console.WriteLine("");   
        Prompt promptGenerator = new Prompt();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
        
    }

    //display the content of the list
    public void Display()
    {
        Console.WriteLine("");
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    //save the list to the external file
    public void Save()
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter the name of the file: ");
        string filename = Console.ReadLine(); 
        Console.WriteLine("Please enter the password for accessing the file: ");
        string password = Console.ReadLine();

        using (StreamWriter passwordsFile = File.AppendText("passwords.txt"))
        {
            passwordsFile.WriteLine($"{filename}~{password}");
        }

        using (StreamWriter outputFile = new StreamWriter(filename))
            
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine(entry.GetText());
                }
                

                
            }
    }


    public void Load()
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter the name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        Console.WriteLine("Please enter the password for the file: ");
        string password = Console.ReadLine();
        string filePassword = "";

        string[] pairs = System.IO.File.ReadAllLines("passwords.txt");
        foreach (string pair in pairs)
        {
            string[] part = pair.Split("~");
            if (part[0] == filename)
            {
                filePassword = part[1];
            }
            
        }
        
        if (password == filePassword)
        {
            entries.Clear();

            foreach (string line in lines)
            {
                string[] split = line.Split("~");
                string date = split[0];
                string prompt = split[1];
                string response = split[2];

                Entry entry = new Entry(prompt, response);
                entries.Add(entry);
                entry.Display();
                
            }
        }

        else
        {
            Console.WriteLine("Password incorrect");
        }

        
    }
    
}



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