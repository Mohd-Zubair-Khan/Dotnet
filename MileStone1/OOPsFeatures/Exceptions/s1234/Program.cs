// See https://aka.ms/new-console-template for more information
using System;

// Custom exception class for negative numbers
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {
        string[] subjects = { "Maths", "Science", "English" };
        int[] marks = new int[3];
        string studentName;

        try
        {
            // FirstName and LastName Validation
            Console.Write("Enter student's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter student's last name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("FirstName and LastName cannot be empty.");

            if (!IsAllAlphabet(firstName) || !IsAllAlphabet(lastName))
                throw new ArgumentException("FirstName and LastName must contain only alphabets.");

            studentName = firstName + " " + lastName;

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write($"Enter marks for {subjects[i]}: ");
                marks[i] = int.Parse(Console.ReadLine());

                // Throw custom exception for negative marks
                if (marks[i] < 0)
                    throw new NegativeNumberException("Marks cannot be negative!");
            }

            Console.WriteLine("\nStudent: " + studentName);
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}: {marks[i]}");
            }
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer marks only.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Helper: Checks if string contains only alphabets
    static bool IsAllAlphabet(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
}
