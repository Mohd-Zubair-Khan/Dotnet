// See https://aka.ms/new-console-template for more information
using System;

class RandomHelper
{
    private static Random random = new Random();

    public static int RandInt(int a, int b)
    {
        return random.Next(a, b + 1); // inclusive
    }

    public static double RandDouble(double a, double b)
    {
        return a + (random.NextDouble() * (b - a));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random Int (1-10): " + RandomHelper.RandInt(1, 10));
        Console.WriteLine("Random Double (1-10): " + RandomHelper.RandDouble(1, 10));
    }
}
