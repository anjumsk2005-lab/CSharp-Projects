using System;
using System.Collections.Generic;

class ServiceToken
{
    public int TokenID { get; set; }
    public string CustomerName { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }
}

class TicketManager
{
    public Queue<ServiceToken> Queue { get; set; }

    private List<ServiceToken> tokenList;
    private int tokenNumber = 1;

    public TicketManager()
    {
        Queue = new Queue<ServiceToken>();
        tokenList = new List<ServiceToken>();
    }

    public void GenerateServiceToken()
    {
        ServiceToken token = new ServiceToken();

        token.TokenID = tokenNumber++;
        Console.Write("Enter Customer Name: ");
        token.CustomerName = Console.ReadLine();
        token.TicketDateTime = DateTime.Now;
        token.Status = "Pending";

        Queue.Enqueue(token);
        tokenList.Add(token);

        Console.WriteLine("Token Created Successfully.");
        Console.WriteLine("Token ID : " + token.TokenID);
    }

    public void GetNextToken()
    {
        if (Queue.Count > 0)
        {
            ServiceToken token = Queue.Peek();

            Console.WriteLine("\nNext Token");
            Console.WriteLine("Token ID : " + token.TokenID);
            Console.WriteLine("Customer : " + token.CustomerName);
            Console.WriteLine("Status : " + token.Status);
        }
        else
        {
            Console.WriteLine("No Tokens Available.");
        }
    }

    public void UpdateToken(int tokenID)
    {
        foreach (ServiceToken token in tokenList)
        {
            if (token.TokenID == tokenID)
            {
                token.Status = "Complete";

                if (Queue.Count > 0 && Queue.Peek().TokenID == tokenID)
                {
                    Queue.Dequeue();
                }

                Console.WriteLine("Token Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("Token Not Found.");
    }

    public void SkipToken()
    {
        if (Queue.Count > 1)
        {
            ServiceToken skipped = Queue.Dequeue();
            ServiceToken next = Queue.Peek();

            Console.WriteLine("Skipped Token : " + skipped.TokenID);
            Console.WriteLine("Next Token : " + next.TokenID);
        }
        else
        {
            Console.WriteLine("Not Enough Tokens.");
        }
    }

    public void ListAllTokens()
    {
        if (tokenList.Count == 0)
        {
            Console.WriteLine("No Tokens Available.");
            return;
        }

        Console.WriteLine("\nAll Tokens");

        foreach (ServiceToken token in tokenList)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Token ID : " + token.TokenID);
            Console.WriteLine("Customer : " + token.CustomerName);
            Console.WriteLine("Date : " + token.TicketDateTime);
            Console.WriteLine("Status : " + token.Status);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicketManager manager = new TicketManager();

        while (true)
        {
            Console.WriteLine("\n******** TOKEN MANAGEMENT SYSTEM ********");
            Console.WriteLine("1. Create Token");
            Console.WriteLine("2. Get Next Token");
            Console.WriteLine("3. Update Token");
            Console.WriteLine("4. Skip Token");
            Console.WriteLine("5. List All Tokens");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.GenerateServiceToken();
                    break;

                case 2:
                    manager.GetNextToken();
                    break;

                case 3:
                    Console.Write("Enter Token ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    manager.UpdateToken(id);
                    break;

                case 4:
                    manager.SkipToken();
                    break;

                case 5:
                    manager.ListAllTokens();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}