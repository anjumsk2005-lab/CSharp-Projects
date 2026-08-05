using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}