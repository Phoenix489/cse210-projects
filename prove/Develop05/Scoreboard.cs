using System.Runtime.Serialization;
public class Scoreboard
{
    //Attributes
    private int _totalPoints;

    //Constructors
    public Scoreboard()
    {
        _totalPoints = 0;
    }
    
    //Deserialize Constructor
    public Scoreboard(string str)
    {
       _totalPoints = int.Parse(str);
    }

    //Methods
    public string DisplayPoints()
    {
        return $"You have {_totalPoints} points.";
    }
    
     public void AddPoints(int pointToScore)
    {
        _totalPoints += pointToScore;
    }

    public string Serialize()
    {
        return $"{_totalPoints}";
    }
}