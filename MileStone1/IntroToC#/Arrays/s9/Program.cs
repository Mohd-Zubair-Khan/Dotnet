// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // 1. Print elements in descending order (no built-in sort)
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Elements in descending order:");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        // 2. Find min and max
        int min = arr[0], max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("Minimum value: " + min);
        Console.WriteLine("Maximum value: " + max);

        // 3. Print the sum
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum of array elements: " + sum);
    }
}
