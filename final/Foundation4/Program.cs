using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2020", 30, 3.0),
            new Cycling("04 Mar 2016", 30, 10.0),
            new Swimming("21 Sept 2008", 30, 10)
        };

        Console.WriteLine("");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}