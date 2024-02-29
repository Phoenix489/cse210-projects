using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        while (userInput != 4) 
        {
            //Menu
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            //Breathing Activity
            if (userInput == 1) 
            {
                BreathingActivity breathing = new BreathingActivity();
                Console.Clear();
                breathing.Run();
            }

            //Reflecting Activity
            else if (userInput == 2) 
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                Console.Clear();
                reflecting.Run();
            }

            //Listing Activity
            else if (userInput == 3) 
            {
                ListingActivity listing = new ListingActivity();
                Console.Clear();
                listing.Run();
            }

            //Quit
            else if (userInput == 4) 
            {
                Console.WriteLine("\nHave a blessed day!\n");
            }

            else
            {
                Console.WriteLine("Invalid Number: Please enter a number based on the menu choices.");
                Thread.Sleep(5000);
            }
        }
    }
}