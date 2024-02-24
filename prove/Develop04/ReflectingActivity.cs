class ReflectingActivity : Activity
{
    //Attributes
    private List<string> _promptList = new List<string>() 
    {
        "stood up for someone else",
        "did something really difficult",
        "helped someone in need",
        "did something truly selfless"
    };

    private List<string> _ponderQuestions = new List<string>() 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    //Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _beginDescription = "This activity will help you to reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //Methods
    public void DisplayRandomPrompt()
    {
        int randomIndex = new Random().Next(_promptList.Count);
        Console.WriteLine($"\nConsider the following prompt:\n");
        Console.WriteLine($"--- Think of a time when you {_promptList[randomIndex]} ---\n");
        Console.WriteLine($"When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
            for (int i = 7; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.Clear();
    }

    public void DisplayPonderQuestions(int _time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            int randomIndex = new Random().Next(_ponderQuestions.Count);
            Console.Write($"> {_ponderQuestions[randomIndex]}\n");
            Spinner(10);
        }
    }
}