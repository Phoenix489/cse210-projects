class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _beginDescription = "This activity will help you to relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }

    //Methods
    public void BreathCounter(int _time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            // 4x4 breathing
            Console.Write($"\nBreathe In... ");
            for (int i = 4; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write($"\nHold Breath... ");
            for (int i = 4; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write($"\nBreathe Out... ");
            for (int i = 4; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write($"\nHold Breath... ");
            for (int i = 4; i > 0; i--) 
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}