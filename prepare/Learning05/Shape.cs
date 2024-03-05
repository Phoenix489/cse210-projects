using System.Formats.Asn1;

public class Shape()
{
    protected string _color;

    public Shape(string color) : this()
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
}