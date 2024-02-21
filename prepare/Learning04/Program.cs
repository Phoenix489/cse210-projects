using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Phoenix Stephan", "C# Program");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine("");

        MathAssignment assignment2 = new MathAssignment("Jake Simpson", "Algebra", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment assignment3 = new WritingAssignment("Ricky Bobby", "Writing", "Talladega Nights");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());    
    }
}