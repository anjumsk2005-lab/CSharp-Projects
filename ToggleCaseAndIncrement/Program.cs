using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine()!;

        string result = "";

        foreach (char ch in input)
        {
            char c = (char)(ch + 1);

            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                    c = char.ToLower(c);
                else
                    c = char.ToUpper(c);
            }

            result += c;
        }

        Console.WriteLine(result);
    }
}