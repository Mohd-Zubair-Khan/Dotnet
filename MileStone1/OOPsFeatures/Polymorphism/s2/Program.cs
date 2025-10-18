// See https://aka.ms/new-console-template for more information
using System;

class MathFunctions
{
    // Add (2 integers)
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add (3 integers)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Multiply (2 integers)
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Multiply (3 integers)
    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    // Subtract (2 integers)
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Divide (2 integers)
    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        return (double)a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathFunctions math = new MathFunctions();

        Console.WriteLine("Add(10, 20): " + math.Add(10, 20));
        Console.WriteLine("Add(5, 7, 9): " + math.Add(5, 7, 9));
        Console.WriteLine("Multiply(3, 4): " + math.Multiply(3, 4));
        Console.WriteLine("Multiply(2, 3, 4): " + math.Multiply(2, 3, 4));
        Console.WriteLine("Subtract(15, 8): " + math.Subtract(15, 8));
        Console.WriteLine("Divide(20, 5): " + math.Divide(20, 5));
    }
}
