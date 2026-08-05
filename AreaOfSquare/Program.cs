using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side: ");
        int side = int.Parse(Console.ReadLine()!);

        int area = side * side;

        Console.WriteLine("Area of square: " + area);
    }
}