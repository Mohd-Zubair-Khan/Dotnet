// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string (digits and alphabets only):");
        string input = Console.ReadLine();

        List<char> AlphaList = new List<char>();
        List<char> DigitList = new List<char>();

        // Split into alphabets and digits
        foreach (char c in input)
        {
            if (Char.IsLetter(c))
                AlphaList.Add(c);
            else if (Char.IsDigit(c))
                DigitList.Add(c);
        }

        // Sort both lists
        AlphaList.Sort();
        DigitList.Sort();

        // Output results
        Console.WriteLine("Sorted Alphabet List: " + String.Join("", AlphaList));
        Console.WriteLine("Sorted Digit List: " + String.Join("", DigitList));
    }
}
