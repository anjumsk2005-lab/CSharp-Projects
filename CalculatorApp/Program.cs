using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new Calculator();

        Console.Write("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + cal.Add(num1, num2));
                break;

            case 2:
                Console.WriteLine("Result = " + cal.Subtract(num1, num2));
                break;

            case 3:
                Console.WriteLine("Result = " + cal.Multiply(num1, num2));
                break;

            case 4:
                Console.WriteLine("Result = " + cal.Divide(num1, num2));
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}