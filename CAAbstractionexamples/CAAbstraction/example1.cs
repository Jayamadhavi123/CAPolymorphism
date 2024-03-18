using System;
public interface IShape
{
    double Area();
}
public class Circle : IShape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Square
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);

        Console.WriteLine($"Area of circle: {circle.Area()}");  
    }
}
