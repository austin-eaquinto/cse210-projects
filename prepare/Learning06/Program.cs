using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning06 World!");

        Square square = new Square("red", 2);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 2, 3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("yellow", 2);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        
        List<Shape> shape = new List<Shape>();
        shape.Add(new Square("pink", 3));
        shape.Add(new Rectangle("cyan", 4, 6));
        shape.Add(new Circle("mustard", 6));

        foreach (var s in shape)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Color: {color}\nArea: {area}");
        }
    }
}