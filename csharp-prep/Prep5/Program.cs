using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName,squaredNumber);

    }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Program! ");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favourite number? ");
            int favNumber = int.Parse(Console.ReadLine())   ;
            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Your name is {name}. ");
            Console.WriteLine($"The squared number is {number}. ");
        }
    
}