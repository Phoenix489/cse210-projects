public class ChecklistGoal : Goal
{
    //Attributes
    private int _bonusPoints;
    private int _goalNumber;
    private int _timesCompleted;

    //Constructor
    public ChecklistGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does the goal need to be accomplished for a bonus? ");
        _goalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    //Constructor to recreate the instances saved away
    public ChecklistGoal(string line)
    {
        //Split the remaining parts of the serialized line into attributes needed
        string[] parts = line.Split(",");

        base.Deserialize(line);
        _bonusPoints = int.Parse(parts[3]);
        _goalNumber = int.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
    }

    //Methods
    public override void RecordEvent()
    {
        //Increment the times completed counter
        _timesCompleted += 1;

        //Display bonus point message for hitting goal number
        if (_timesCompleted == _goalNumber)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points and {_bonusPoints} bonus points! ");
        }
        //Display normal point message 
        else 
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    } 

    public override int GetPoints(Goal goal)
    {
        //Add Bonus Points if goal was reached
        if (_timesCompleted == _goalNumber)
        {
            return _bonusPoints + _points;
        }
        //Normal points without the bonus
        else 
        {
            return _points;
        }
    }

    public override string DisplayGoal()
    {
        //Display '[X]' for completing goal fully
        if (_timesCompleted >= _goalNumber)
        {
            return $"[X] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_goalNumber}";
        }
        
        //Display '[ ]' because the goal is still unfinished
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_goalNumber}";
        }
    }

    //Prepare to save
    public override string Serialize()
    {
        return $"{base.Serialize()},{_bonusPoints},{_goalNumber},{_timesCompleted}";
    }

}