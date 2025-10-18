// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        bool found = false;

        if ((number1 % 10) == number2)
        {
            Console.WriteLine($"{number2} is in unit's place of {number1}");
            found = true;
        }
        if ((number1 / 10) % 10 == number2)
        {
            Console.WriteLine($"{number2} is in ten's place of {number1}");
            found = true;
        }
        if ((number1 / 100) % 10 == number2)
        {
            Console.WriteLine($"{number2} is in hundred's place of {number1}");
            found = true;
        }
        if ((number1 / 1000) % 10 == number2)
        {
            Console.WriteLine($"{number2} is in thousand's place of {number1}");
            found = true;
        }
        if (!found)
        {
            Console.WriteLine($"{number2} is not present in any required place of {number1}");
        }
    }
}
