using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Product Name: ");
        string product = Console.ReadLine()!;

        Console.Write("Enter Quantity: ");
        int quantity = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine()!);

        double total = quantity * price;

        Console.WriteLine("\nStock Details");
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Total Value: " + total);
    }
}