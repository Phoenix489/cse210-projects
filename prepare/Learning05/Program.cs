using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 8);
        

        Circle circle = new Circle("Red", 4);
        

        Rectangle rectangle = new Rectangle("Yellow", 5, 2);
        

        List<Shape> shapes = new List<Shape>();
        shapes = [square, circle, rectangle];

        foreach (Shape shape in shapes)
        {
            // Console.WriteLine(shape.GetColor());
            // Console.WriteLine(shape.GetArea());
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The color of the shape is {color}. The area is {area}.");
        }
    }
}