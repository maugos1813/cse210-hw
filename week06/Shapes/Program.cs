using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square color: {square.GetColor()} - Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()} - Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle color: {circle.GetColor()} - Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("\n--- List of Shapes ---");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()} - Area: {shape.GetArea():F2}");
        }
    }
}
