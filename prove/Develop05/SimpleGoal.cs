using System.Runtime.InteropServices;
public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;

    //Constructor
    public SimpleGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    //Constructor after Deserialization
    public SimpleGoal(string line)
    {
        string[] parts = line.Split(",");

        base.Deserialize(line);
        _isComplete = bool.Parse(parts[3]);
    }

    //Methods
    public override void RecordEvent()
    {
        //Display different messages depending on if the task has already been completed or not
        if (_isComplete == true)
        {
            Console.WriteLine("This task has already been completed! ");
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public override string DisplayGoal()
    {
        //Display different messages depending on if the task has already been completed or not
        if (_isComplete == true)
        {
            return $"[X] {_name} ({_description})";
        }

        else 
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public override string Serialize()
    {
        return $"{base.Serialize()},{_isComplete}";
    }
}