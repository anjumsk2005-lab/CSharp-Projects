using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Hourly Employee =====");

        HourlyEmployee h = new HourlyEmployee(
            "Anjum",
            "Sheik",
            "anjum@gmail.com",
            new DateTime(2005, 4, 29),
            40,
            500);

        h.CalculatePay();
        h.Display();

        Console.WriteLine();

        Console.WriteLine("===== Permanent Employee =====");

        PermanentEmployee p = new PermanentEmployee(
            "Anjum",
            "Sheik",
            "anjum@gmail.com",
            new DateTime(2005, 4, 29),
            50000);

        p.CalculatePay();
        p.Display();
    }
}