// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string incremented = "";

        // Increment each character by 1
        foreach (char c in input)
        {
            incremented += (char)(c + 1);
        }

        // Toggle case
        string toggled = "";
        foreach (char c in incremented)
        {
            if (char.IsUpper(c))
                toggled += char.ToLower(c);
            else if (char.IsLower(c))
                toggled += char.ToUpper(c);
            else
                toggled += c;
        }

        Console.WriteLine("Incremented string: " + incremented);
        Console.WriteLine("Toggled case string: " + toggled);
    }
}
