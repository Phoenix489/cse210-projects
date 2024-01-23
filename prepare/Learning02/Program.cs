using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "BYUi"; 
        job1._jobTitle = "Audio Technician";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Southern Graces"; 
        job2._jobTitle = "Event Specialist";
        job2._startYear = 2015;
        job2._endYear = 2018;

        Resume resume = new Resume();
        resume._name = "Phoenix Stephan";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}