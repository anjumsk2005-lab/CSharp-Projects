using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string fname = Console.ReadLine()!;

        Console.Write("Enter Last Name: ");
        string lname = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Enter Date of Birth (dd/mm/yyyy): ");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(fname, lname, email, dob, salary);

        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("------------------------");
        Console.WriteLine("Is Adult : " + emp.IsAdult);
        Console.WriteLine("Sun Sign : " + emp.SunSign);
        Console.WriteLine("Is Birthday : " + emp.IsBirthDay);
        Console.WriteLine("Screen Name : " + emp.ScreenName);
        Console.WriteLine("Salary : " + emp.Salary);
    }
}