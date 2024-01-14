using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string replay = "";
        do
        {

            // Ask the user for the magic number and parse into an int. 
            // Console.Write("What is the magic number? ");
            // string userInputNumber = Console.ReadLine();
            // int magicNumber = int.Parse(userInputNumber);

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess = -1;
            int attempts = 0;

            do 
            {
                // Ask for and store guess. 
                Console.Write("What is your guess? ");
                string userInputGuess = Console.ReadLine();
                guess = int.Parse(userInputGuess);

                // Logic to determine if guess was too high, low, or correct.
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it!\nIt took you {attempts} tries before you guessed the correct number!");
                    Console.Write("Would you like to play again? (yes/no) ");
                    replay = Console.ReadLine(); 
                }

                attempts++;
            } while (magicNumber != guess);
        } while (replay == "yes");
    }
}