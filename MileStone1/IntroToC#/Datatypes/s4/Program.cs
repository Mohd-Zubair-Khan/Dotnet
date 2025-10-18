// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // 1) Print the string in reverse order
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine("Reversed String: " + reversed);

        // 2) Extract part of the string from 2nd position till the end of the string
        if (input.Length > 1)
        {
            string substring = input.Substring(1);
            Console.WriteLine("Substring from 2nd position: " + substring);
        }
        else
        {
            Console.WriteLine("Substring from 2nd position: (Input too short)");
        }

        // 3) Replace any given character by '$' and print the new string
        Console.WriteLine("Enter a character to replace by '$':");
        char toReplace = Console.ReadLine()[0];
        string replaced = input.Replace(toReplace, '$');
        Console.WriteLine("String after replacing '" + toReplace + "': " + replaced);

        // 4) Copy the string to another string variable, modify the data in 2nd string variable and print both strings
        string copyString = input;
        string modifiedString = copyString + "_modified";
        Console.WriteLine("Original String: " + copyString);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}
