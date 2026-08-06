using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<char> AlphaList = new List<char>();
        List<char> DigitList = new List<char>();

        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                AlphaList.Add(ch);
            }
            else if (char.IsDigit(ch))
            {
                DigitList.Add(ch);
            }
        }

        AlphaList.Sort();
        DigitList.Sort();

        Console.WriteLine("AlphaList");

        foreach (char c in AlphaList)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine();

        Console.WriteLine("DigitList");

        foreach (char c in DigitList)
        {
            Console.Write(c + " ");
        }
    }
}