using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine()!;

        char[] arr = s.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine("Reverse: " + new string(arr));
        Console.WriteLine("Substring: " + s.Substring(1));

        Console.Write("Character to replace: ");
        char ch = char.Parse(Console.ReadLine()!);

        Console.WriteLine("New String: " + s.Replace(ch, '$'));

        string copy = s + " Copy";

        Console.WriteLine("Original: " + s);
        Console.WriteLine("Copied: " + copy);
    }
}