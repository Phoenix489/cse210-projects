using System;
using System.Runtime.InteropServices;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!\nWelcome to the Journal Program!");
        int choice = 0;
        Journal journalInstance = new Journal();

        string[] journalPrompts =
        [
            "Describe a moment that made you feel proud.",
            "Write about a challenge you overcame recently.",
            "If you could have dinner with any historical figure, who would it be and why?",
            "What are three things you are grateful for today?",
            "Explore a goal you want to achieve and outline the steps to get there.",
            "Write about a book, movie, or song that had a significant impact on you.",
            "Describe a place that holds special memories for you.",
            "Discuss a skill or hobby you would like to learn in the future.",
            "If you could travel anywhere in the world, where would you go and why?",
            "Reflect on a difficult decision you had to make and the lessons learned."
        ];


        while (choice != 5) {
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n What would you like to do? ");
            choice = int.Parse(Console.ReadLine()); 

            // Write
            if (choice == 1) {

                string prompt = journalPrompts[new Random().Next(0, journalPrompts.Length)];
                Console.WriteLine(prompt);
                Console.Write("> ");
                string writing = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                journalInstance.AddEntry(writing, prompt, dateText);
            }

            // Display
            else if (choice == 2) {
                Console.WriteLine(journalInstance.Display());
            }

            // Load from File
            else if (choice == 3) {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);
                journalInstance = new Journal();
                journalInstance.loadedFileLines = lines;
            }

            // Save to File
            else if (choice == 4) {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.Write(journalInstance.Display());
                }
            }
        }
    }
}
