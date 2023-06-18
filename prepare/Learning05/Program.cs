using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("red", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("blue", 10, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("yellow", 6);
        shapes.Add(shape3);

        Console.WriteLine();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }

        Console.WriteLine();
    }
}