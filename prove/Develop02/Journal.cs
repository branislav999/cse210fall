
using System;
using System.IO;

public class Journal 
{

    //list that stores user's inputs
    public List<Entry> _entries = new List<Entry>();

    //storing the input in the list
    public void Write()
    {
        Console.WriteLine("");   
        Prompt promptGenerator = new Prompt();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
        
    }

    //display the content of the list
    public void Display()
    {
        Console.WriteLine("");
        foreach (Entry entry in _entries)
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
                foreach (Entry entry in _entries)
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
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] split = line.Split("~");
                string date = split[0];
                string prompt = split[1];
                string response = split[2];

                Entry entry = new Entry(prompt, response);
                _entries.Add(entry);
                entry.Display();
                
            }
        }

        else
        {
            Console.WriteLine("Password incorrect");
        }

        
    }
    
}



