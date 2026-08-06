using System;

class Student
{
    public int RollNo;
    public string Name;
    public string Branch;
    public double Marks;

    public void GetDetails()
    {
        Console.Write("Enter Roll No: ");
        RollNo = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Name: ");
        Name = Console.ReadLine()!;

        Console.Write("Enter Branch: ");
        Branch = Console.ReadLine()!;

        Console.Write("Enter Marks: ");
        Marks = double.Parse(Console.ReadLine()!);
    }

    public void Display()
    {
        Console.WriteLine("\nStudent Details");
        Console.WriteLine("Roll No : " + RollNo);
        Console.WriteLine("Name    : " + Name);
        Console.WriteLine("Branch  : " + Branch);
        Console.WriteLine("Marks   : " + Marks);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.GetDetails();
        s.Display();
    }
}