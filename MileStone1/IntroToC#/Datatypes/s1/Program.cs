// See https://aka.ms/new-console-template for more information
using System;

class SquareArea
{
    static void Main()
    {
        Console.Write("Enter the side of the square: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double side))
        {
            double area = side * side;
            Console.WriteLine("The area of the square is: " + area);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
