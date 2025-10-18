// See https://aka.ms/new-console-template for more information
using System;

public class Calculator
{
    // Add operation
    public double Add(double a, double b) => a + b;

    // Subtract operation
    public double Subtract(double a, double b) => a - b;

    // Multiply operation
    public double Multiply(double a, double b) => a * b;

    // Divide operation; throws exception for divide by zero
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        while (true)
        {
            Console.WriteLine("\n****** CONSOLE CALCULATOR ******");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Choose operation: ");
            string op = Console.ReadLine();

            if (op == "5")
                break;

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            try
            {
                double result = 0;
                switch (op)
                {
                    case "1":
                        result = calc.Add(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "2":
                        result = calc.Subtract(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "3":
                        result = calc.Multiply(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "4":
                        result = calc.Divide(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
