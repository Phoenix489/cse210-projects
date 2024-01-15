using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        
        do 
        {
            // Ask for a number from the user and convert the string to int.
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            // Add user numbers to list.
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int total = 0; 
        foreach (int userNumber in numbers)
        {
            total = total + userNumber;
        }

        int listSize = numbers.Count;
        float average = ((float)total) / listSize;
        int biggestNumber = 0;

        foreach(int userNumber in numbers)
        {
            if (userNumber > biggestNumber)
            {
                biggestNumber = userNumber;
            }
        }

        int smallestPositiveNumber = 999;
        foreach (int userNumber in numbers)
        {
            if (userNumber > 0)
            {
                if (userNumber < smallestPositiveNumber)
                {
                    smallestPositiveNumber = userNumber;
                }
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");    
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is: ");

        numbers.Sort();
        foreach (int userNumber in numbers)
        {
            Console.WriteLine(userNumber);
        }
    }
}