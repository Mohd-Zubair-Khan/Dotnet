// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "samplefile.txt";
        string content;

        Console.WriteLine("Enter content to write to the file:");
        content = Console.ReadLine();

        // Create the file and write content
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(content);
            Console.WriteLine("Content written to file successfully.");
        }

        // Optionally, you can show that the file is closed and read back its contents
        Console.WriteLine("\nReading content from saved file:");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string readContent = reader.ReadToEnd();
            Console.WriteLine(readContent);
        }
    }
}
