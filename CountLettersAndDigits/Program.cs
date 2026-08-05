using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine()!;

        int letters = 0;
        int digits = 0;

        foreach (char ch in s)
        {
            if (char.IsLetter(ch))
                letters++;
            else if (char.IsDigit(ch))
                digits++;
        }

        Console.WriteLine("Letters: " + letters);
        Console.WriteLine("Digits: " + digits);
    }
}