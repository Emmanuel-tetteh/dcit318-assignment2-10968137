using System;

abstract class Shape
{
    public abstract void GetArea(params int[] measures);
}

class Circle : Shape
{
    public override void GetArea(params int[] measures)
    {
        if (measures.Length != 1)
        {
            Console.WriteLine("Circle requires exactly one measure (radius).");
            return;
        }

        int radius = measures[0];
        float Area = (float)(Math.PI * radius * radius);

        Console.WriteLine("Area of circle is " + Area);
    }
}

class Rectangle : Shape
{
    public override void GetArea(params int[] measures)
    {
        if (measures.Length != 2)
        {
            Console.WriteLine("Rectangle requires exactly two measures (length and breadth).");
            return;
        }

        int length = measures[0];
        int breadth = measures[1];
        float Area = length * breadth;

        Console.WriteLine("Area of Rectangle is " + Area);
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle();
        circle.GetArea(5); // Example radius

        Shape rectangle = new Rectangle();
        rectangle.GetArea(4, 5); // Example length and breadth
    }
}
