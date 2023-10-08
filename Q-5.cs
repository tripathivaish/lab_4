using System;

public abstract class GeometricShape
{
    public abstract double CalculateArea();
}

public class Circle : GeometricShape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
  
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
public class Rectangle : GeometricShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
   
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
class Program
{
    static void Main()
    {
        GeometricShape circle = new Circle(5.0);
        GeometricShape rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
        Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
    }
}