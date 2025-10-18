// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string correctUsername = "admin"; // Change as needed
        string correctPassword = "1234";  // Change as needed
        int attempts = 0;
        bool isAuthenticated = false;

        while (attempts < 3)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                isAuthenticated = true;
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid credentials. Try again.");
            }
        }

        if (isAuthenticated)
            Console.WriteLine("Login successful!");
        else
            Console.WriteLine("User rejected after 3 unsuccessful attempts.");
    }
}
