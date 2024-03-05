using System.Drawing;

public class Square : Shape
{
    private int _side;

    public Square(string color, int side) : base(color) 
    {
        _side = side;
        _color = color;; 
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}