using System;

class Program
{
    static void Main(string[] args)
    {
        MyMath obj = new MyMath();

        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Addition (2 numbers)= " + obj.Add(a, b));
        Console.WriteLine("Addition (3 numbers)= " + obj.Add(a, b, c));

        Console.WriteLine("Subtraction (2 numbers)= " + obj.Subtract(a, b));
        Console.WriteLine("Subtraction (3 numbers)= " + obj.Subtract(a, b, c));

        Console.WriteLine("Multiplication (2 numbers)= " + obj.Multiply(a, b));
        Console.WriteLine("Multiplication (3 numbers)= " + obj.Multiply(a, b, c));

        Console.WriteLine("Division (2 numbers)= " + obj.Divide(a, b));
        Console.WriteLine("Division (3 numbers)= " + obj.Divide(a, b, c));
    }
}