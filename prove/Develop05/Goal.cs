public abstract class Goal
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _points;

    //Methods
    public abstract string DisplayGoal();
    public abstract void RecordEvent();
    public  virtual string Serialize()
    {
        return $"{GetType()}:{_name},{_description},{_points}";
    }

    public virtual void Deserialize(string line)
    {
        string[] parts = line.Split(",");

        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }

    public virtual int GetPoints(Goal goal)
    {
        return _points;
    }
    
    public virtual string DisplayGoalName()
    {
        return $"{_name}";
    }
}