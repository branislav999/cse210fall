using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool choice = true;

        while (choice)
        {

            Display display = new Display();
            display.DisplayMenu();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Breathing breathing1 = new Breathing();
                    breathing1.StartBreathingActivity();
                    break;

                case "2":
                    Reflection reflection1 = new Reflection();
                    reflection1.StartReflectionActivity();
                    break;

                case "3":
                    Listing listing = new Listing();
                    listing.StartListingActivity();
                    break;

                case "4":
                    choice = false;
                    break;
            }

        }
        
    }
}

class Display
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu \n1.Breathing Activity \n2.Reflection Activity \n3.Listing Activity \n4.Quit ");
    }
}