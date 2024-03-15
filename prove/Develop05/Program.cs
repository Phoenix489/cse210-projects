using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Create Empty Goal List
        List<Goal> goals = new List<Goal>();

        //Scoreboard instance
        Scoreboard scoreboard = new Scoreboard();

        //Menu Loop
        int userInput = 0;
        while (userInput != 6) 
        {
            //Menu
            Console.Write("\n");
            Console.Write(scoreboard.DisplayPoints());
            Console.Write("\n");

            Console.WriteLine("\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            //Create New Goal
            if (userInput == 1) 
            {
                Console.WriteLine("The type of goals are:\n  1. Simple Goals\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
                int userGoal = int.Parse(Console.ReadLine());
                
                //SimpleGoal
                if (userGoal == 1)
                {   
                    SimpleGoal simpleGoal = new SimpleGoal();
                    goals.Add(simpleGoal);
                }

                //EternalGoal
                else if (userGoal == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    goals.Add(eternalGoal);
                }

                //ChecklistGoal
                else if (userGoal == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    goals.Add(checklistGoal);
                }

                else 
                {
                    Console.WriteLine("Invalid Input.");
                    Thread.Sleep(5000);
                }
            }

            //List Goals
            else if (userInput == 2) 
            {
                int number = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goals)
                {
                    Console.Write($"{number}. ");
                    Console.Write(goal.DisplayGoal());
                    Console.Write($"\n");
                    number += 1;
                }
            }

            //Save Goals
            else if (userInput == 3) 
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string fileToSave = Console.ReadLine();
                Save(fileToSave);
            }

            //Load Goals
            else if (userInput == 4) 
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string fileToLoad = Console.ReadLine();
                Load(fileToLoad);
            }

            //Record Event
            else if (userInput == 5) 
            {
                //Display Goals in a list format
                int number = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goals)
                {
                    Console.Write($"{number}. ");
                    Console.Write(goal.DisplayGoalName());
                    Console.Write($"\n");
                    number += 1;
                }

                //Allow user to select goal to complete
                Console.WriteLine("What goal did you accomplish? ");
                int userNum = int.Parse(Console.ReadLine());
                goals[userNum - 1].RecordEvent();
                int point = goals[userNum - 1].GetPoints(goals[userNum -1]);
                scoreboard.AddPoints(point);
            }

            //Quit
            else if (userInput == 6) 
            {
                Console.WriteLine("Did you save your goals? Are you sure you would like to quit? (Y/N)");
                string response = Console.ReadLine();
                response.ToLower();
                if (response == "y")
                {
                    Console.Write(scoreboard.DisplayPoints());
                    Console.WriteLine($"\nHave a blessed day!");
                } 
                else if (response == "n")
                {
                    userInput = 0;
                    Console.WriteLine($"\nSave your file! Then quit!");
                    Thread.Sleep(5000);
                }
                else
                {
                    userInput = 0;
                    Console.WriteLine("Invalid Number: Please enter a number based on the menu choices.");
                    Thread.Sleep(5000); 
                }
            }

            else
            {
                Console.WriteLine("Invalid Number: Please enter a number based on the menu choices.");
                Thread.Sleep(5000);
            }
        }

        // Function to save to file
        void Save(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(scoreboard.Serialize());

                foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.Serialize());
                    }
            }
        }

        // Function to load data from file
        void Load(string fileName)
        {
            
            string[] lines = System.IO.File.ReadAllLines(fileName);
            scoreboard = new Scoreboard(lines[0]);
            goals = new List<Goal>();
            
            foreach (string line in lines.Skip(1))
            {
                int colonIndex = line.IndexOf(':');
                string classType = line.Substring(0, colonIndex);
                if (classType == "SimpleGoal")
                {
                    Goal goal = new SimpleGoal(line.Substring(colonIndex + 1));
                    goals.Add(goal);
                }
                else if (classType == "EternalGoal")
                {
                    Goal goal = new EternalGoal(line.Substring(colonIndex + 1));
                    goals.Add(goal);
                }
                else if (classType == "ChecklistGoal")
                {
                    Goal goal = new ChecklistGoal(line.Substring(colonIndex + 1));
                    goals.Add(goal);
                } 
            }
        }
    }
}