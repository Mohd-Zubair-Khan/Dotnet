// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());

        // 1) Assign num1 to num2 by pre-incrementing num1 and observe the output
        num2 = ++num1; // Pre-increment
        Console.WriteLine("After pre-increment: num1 = " + num1 + ", num2 = " + num2);

        // 2) Assign num1 to num2 by post-incrementing num1 and observe the output
        num2 = num1++; // Post-increment
        Console.WriteLine("After post-increment: num1 = " + num1 + ", num2 = " + num2);

        // 3) Swap both values
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2);
    }
}
