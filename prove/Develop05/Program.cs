using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        while (userInput != 6) 
        {
            //Menu
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            //Create New Goal
            if (userInput == 1) 
            {
                Console.WriteLine("The type of goals are:\n  1. Simple Goals\n  2. Eternal Goal\n  3.Checklist Goal\nWhich type of goal would you like to create? ");
                // int userGoal = int.Parse(Console.ReadLine());
            }

            //List Goals
            else if (userInput == 2) 
            {
                Console.WriteLine("The goals are: ");
            }

            //Save Goals
            else if (userInput == 3) 
            {
                
            }

            //Load Goals
            else if (userInput == 4) 
            {
            
            }

            //Record Event
            else if (userInput == 5) 
            {
                
            }

            //Quit
            else if (userInput == 6) 
            {
                Console.WriteLine("Have a blessed day!");
            }

            else
            {
                Console.WriteLine("Invalid Number: Please enter a number based on the menu choices.");
                Thread.Sleep(5000);
            }
        }
    }
}