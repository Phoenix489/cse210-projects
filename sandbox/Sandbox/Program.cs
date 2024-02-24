using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Get ready...");
        //Animation List 
        List<string> animationStrings = new List<string>();
        animationStrings = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

        //Set duration for 5 seconds
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}