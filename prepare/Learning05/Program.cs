using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("green", 15);
        Rectangle s2 = new Rectangle("yellow", 10, 23);
        Circle s3 = new Circle("purple", 14);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
    }
}