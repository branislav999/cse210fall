using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int targetNumber = randomNumber.Next(1,100);

        int userGuess = -1;
        int count = 0;

        bool playAgain = false;

        while (targetNumber != userGuess && !playAgain)
        {   
            Console.Write("What is your guess? ");
            string userGuessString = Console.ReadLine();
            userGuess = int.Parse(userGuessString);
            count += 1;

            if (targetNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (targetNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {count} tries. ");
                Console.Write("Do you want to play again? yes/no ");
                
                string response = Console.ReadLine();
                if (response == "yes") {
                    targetNumber = randomNumber.Next(1,100);
                    count = 0;
                }
                else 
                {
                    Console.WriteLine("Thanks for playing ");
                    playAgain = true;

                }
            }
            

            
            
        }
    }
}