// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// ServiceToken class
public class ServiceToken
{
    private static int nextID = 1001; // Auto-generated TokenID

    public int TokenID { get; private set; }
    public string Position { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }

    public ServiceToken(string position)
    {
        TokenID = nextID++;
        Position = position;
        TicketDateTime = DateTime.Now;
        Status = "Pending";
    }
}

// TicketManager class
public class TicketManager
{
    public Queue<ServiceToken> TokenQueue { get; set; } = new Queue<ServiceToken>();
    private List<ServiceToken> allTokens = new List<ServiceToken>();

    // Create a new token
    public void GenerateServiceToken(string position)
    {
        ServiceToken token = new ServiceToken(position);
        TokenQueue.Enqueue(token);
        allTokens.Add(token);
        Console.WriteLine($"Token Created: ID={token.TokenID}, Position={token.Position}");
    }

    // Get next available token
    public ServiceToken GetNextToken()
    {
        if (TokenQueue.Count > 0)
        {
            ServiceToken next = TokenQueue.Peek();
            Console.WriteLine($"Next Token: ID={next.TokenID}, Position={next.Position}, Status={next.Status}");
            return next;
        }
        else
        {
            Console.WriteLine("No tokens available.");
            return null;
        }
    }

    // Update a token status by ID
    public void UpdateToken(int tokenID)
    {
        foreach (var token in allTokens)
        {
            if (token.TokenID == tokenID)
            {
                token.Status = "Complete";
                // Also remove from the front if it's next up
                if (TokenQueue.Count > 0 && TokenQueue.Peek().TokenID == tokenID)
                    TokenQueue.Dequeue();
                Console.WriteLine($"Token {tokenID} marked as Complete.");
                return;
            }
        }
        Console.WriteLine("Token ID not found.");
    }

    // Skip next token and return next one
    public void SkipToken()
    {
        if (TokenQueue.Count > 0)
        {
            ServiceToken skipped = TokenQueue.Dequeue();
            Console.WriteLine($"Token {skipped.TokenID} skipped.");
            GetNextToken();
        }
        else
        {
            Console.WriteLine("No tokens to skip.");
        }
    }

    // List all tokens
    public void ListTokens()
    {
        if (allTokens.Count == 0)
        {
            Console.WriteLine("No tokens generated yet.");
            return;
        }
        Console.WriteLine("All Tokens:");
        foreach (var token in allTokens)
        {
            Console.WriteLine($"ID: {token.TokenID}, Position: {token.Position}, DateTime: {token.TicketDateTime}, Status: {token.Status}");
        }
    }
}

// MENU-DRIVEN DRIVER
class Program
{
    static void Main(string[] args)
    {
        TicketManager manager = new TicketManager();

        while (true)
        {
            Console.WriteLine("\n*********** TOKEN MANAGEMENT SYSTEM ***********");
            Console.WriteLine("1. Create Token");
            Console.WriteLine("2. Get Next Token");
            Console.WriteLine("3. Update Token");
            Console.WriteLine("4. Skip Token");
            Console.WriteLine("5. List all Tokens");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your Choice: ");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.Write("Enter Position/Service Type: ");
                    string pos = Console.ReadLine();
                    manager.GenerateServiceToken(pos);
                    break;
                case "2":
                    manager.GetNextToken();
                    break;
                case "3":
                    Console.Write("Enter Token ID to update: ");
                    if (int.TryParse(Console.ReadLine(), out int upID))
                        manager.UpdateToken(upID);
                    else
                        Console.WriteLine("Invalid Token ID.");
                    break;
                case "4":
                    manager.SkipToken();
                    break;
                case "5":
                    manager.ListTokens();
                    break;
                case "6":
                    Console.WriteLine("Exiting application...");
                    return;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
