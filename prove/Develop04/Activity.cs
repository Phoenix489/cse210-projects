public class Activity 
{
    //Attributes
    protected string _name;

    protected string _beginDescription;

    private int _time;

    //Methods
    public void DisplayBeginMessage() 
    {
        Console.WriteLine($"Welcome to the {_name}.\n{_beginDescription}");
    }

    public int PromptTimer()
    {
        Console.Write("\nHow long, in seconds, would you like your session to last? ");
        return _time = int.Parse(Console.ReadLine());
    }

    public void PrepareUser()
    {
        Console.WriteLine("Get ready...");
        Spinner(5);
    }

    public void Spinner(int duration)
    {
        //Animation List 
        List<string> animationStrings = new List<string>();
        animationStrings = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

        //Set duration for 5 seconds
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        //Spin Loop
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            
            //Reset the index once it reaches the end of the list. 
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void Countdown(int beginTime) 
    {
        Console.Write($"You may begin in: ");
            for (int i = beginTime; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void CongratulateUser()
    {
        Console.WriteLine("\nWell Done!");
        Spinner(5);
        Console.WriteLine($"You have completed {_time} seconds of the {_name}.");
        Spinner(5);
        Console.Clear();
    }
}