// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] arr = {12, 23, 34, 45, 56}; // Sample static array
        int count = 0;

        // Find number of elements without Length property
        foreach (int num in arr)
        {
            count++;
        }

        Console.WriteLine("Number of elements in array: " + count);
    }
}
