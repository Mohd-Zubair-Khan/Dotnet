// See https://aka.ms/new-console-template for more information
using System;

class AreaCalculator
{
    // Area of circle: πr^2
    public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Area of rectangle: length * width
    public double Area(double length, double width)
    {
        return length * width;
    }

    // Area of triangle: 0.5 * base * height
    public double Area(double b, double height, bool isTriangle)
    {
        if (isTriangle)
            return 0.5 * b * height;
        else
            return 0.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        AreaCalculator calc = new AreaCalculator();

        double circleArea = calc.Area(5); // radius = 5
        Console.WriteLine("Area of Circle (radius 5): " + circleArea);

        double rectangleArea = calc.Area(4, 6); // length = 4, width = 6
        Console.WriteLine("Area of Rectangle (4 x 6): " + rectangleArea);

        double triangleArea = calc.Area(3, 7, true); // base = 3, height = 7
        Console.WriteLine("Area of Triangle (base 3, height 7): " + triangleArea);
    }
}
