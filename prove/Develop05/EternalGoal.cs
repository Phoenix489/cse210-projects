public class EternalGoal : Goal
{
    //Attributes
    private int _timesCompleted = 0;

    //Constructors
    public EternalGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    
    //Constructor after deserializing
    public EternalGoal(string line)
    {
        string[] parts = line.Split(",");

        base.Deserialize(line);
        _timesCompleted = int.Parse(parts[3]);
    }

    //Methods
    public override void RecordEvent()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override string DisplayGoal()
    {
        return $"[Times Completed - {_timesCompleted}] {_name} ({_description})";
    }
    
    public  override string Serialize()
    {
        return $"{base.Serialize()},{_timesCompleted}";
    }
}