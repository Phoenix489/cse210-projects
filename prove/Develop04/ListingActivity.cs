class ListingActivity : Activity
{
    //Attributes
    private List<string> _promptList = new List<string>() 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //Constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _beginDescription = "This activity will help you to reflect on the good things in your life by having you\nlist as many things as you can in a certain area.";
    }

    //Methods
    public void DisplayPrompt()
    {
        //Intro Text
        Console.WriteLine($"\nList as many responses as you can to the following prompt: ");

        //Grab and Display Random Prompt from List
        int randomIndex = new Random().Next(_promptList.Count);
        Console.WriteLine($"--- {_promptList[randomIndex]} ---\n");

        //Countdown till beginning
        Countdown(8);
    }

    public void RecordResponses(int _time)
    {
        //Set Timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        //Set ResponseCount - Create Response List
        int responseCount = 0;
        List<string> responses = new List<string>();


        //Formatting
        Console.WriteLine("");

        //Loop till Timer expires - Keep track of how many responses are entered and add them to a list
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            responseCount += 1;
            responses.Add(answer);
        }

        // Clear terminal to display results
        Console.Clear();

        //Display Results
        Console.WriteLine($"You listed {responseCount} items:");
        int num = 1;
        foreach (string i in responses)
        {
            Console.WriteLine($"{num}. {i}");
            num += 1;
        }

        //User may continue at their own pace
        Console.WriteLine("Hit enter to continue: ");
        Console.ReadLine();
    }
}