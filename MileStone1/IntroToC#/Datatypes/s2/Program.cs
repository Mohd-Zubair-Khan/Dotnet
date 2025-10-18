// See https://aka.ms/new-console-template for more information
using System;

class CountDigitsAndAlphabets
{
    static void Main()
    {
        // Ask user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Initialize counters
        int digitCount = 0;
        int alphabetCount = 0;

        // Loop through each character
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
            else if (char.IsLetter(c))
            {
                alphabetCount++;
            }
        }

        // Display results
        Console.WriteLine("Number of digits: " + digitCount);
        Console.WriteLine("Number of alphabets: " + alphabetCount);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
