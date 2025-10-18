// See https://aka.ms/new-console-template for more information
using System;

public class MathOperations
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

// Delegate declaration
public delegate double MathDelegate(double x, double y);

class Program
{
    static void Main(string[] args)
    {
        MathOperations ops = new MathOperations();

        MathDelegate addDel = new MathDelegate(ops.Add);
        MathDelegate subDel = new MathDelegate(ops.Subtract);
        MathDelegate mulDel = new MathDelegate(ops.Multiply);
        MathDelegate divDel = new MathDelegate(ops.Divide);

        Console.WriteLine("Enter first number:");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Add: " + addDel(n1, n2));
        Console.WriteLine("Subtract: " + subDel(n1, n2));
        Console.WriteLine("Multiply: " + mulDel(n1, n2));

        try
        {
            Console.WriteLine("Divide: " + divDel(n1, n2));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Divide Error: " + ex.Message);
        }
    }
}
