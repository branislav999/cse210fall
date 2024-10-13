using System;
using System.Data.Common;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
           
    
        bool continueLoop = true;

        while (continueLoop){
            
            Console.WriteLine("");
            prompt.DisplayMenu();
            string input = Console.ReadLine();

            switch (input)
            {

                case "1":
                    journal.Write();
                    break;

                case "2":
                    journal.Display();                 
                    break;

                case "3":
                    journal.Save();
                    break;
                
                case "4":
                    journal.Load();
                    break;

                case "5":
                    continueLoop = false;
                    break;

            }
        }

    }
}