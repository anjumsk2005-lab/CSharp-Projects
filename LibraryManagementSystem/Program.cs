using System;

class Book
{
    public int BookId;
    public string Title;
    public string Author;

    public void GetDetails()
    {
        Console.Write("Enter Book ID: ");
        BookId = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Book Title: ");
        Title = Console.ReadLine()!;

        Console.Write("Enter Author Name: ");
        Author = Console.ReadLine()!;
    }

    public void Display()
    {
        Console.WriteLine("\nLibrary Details");
        Console.WriteLine("----------------------");
        Console.WriteLine("Book ID   : " + BookId);
        Console.WriteLine("Title     : " + Title);
        Console.WriteLine("Author    : " + Author);
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        book.GetDetails();

        book.Display();
    }
}