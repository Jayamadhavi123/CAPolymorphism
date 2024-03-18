using System;
public abstract class Shape
{
    public abstract double Area();

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    
    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 4);

      
        rectangle.Display();  
        Console.WriteLine($"Area of rectangle: {rectangle.Area()}");  
    }
}

