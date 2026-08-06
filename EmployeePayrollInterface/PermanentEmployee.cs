using System;

class PermanentEmployee : Person, IPayable
{
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public double TotalPay { get; set; }

    public PermanentEmployee(string firstName, string lastName, string email,
        DateTime dob, double basicSalary)
        : base(firstName, lastName, email, dob)
    {
        BasicSalary = basicSalary;
    }

    public void CalculatePay()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        TotalPay = BasicSalary + HRA + DA;
        Tax = TotalPay * 0.08;
        NetPay = TotalPay - Tax;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Basic Salary : " + BasicSalary);
        Console.WriteLine("HRA : " + HRA);
        Console.WriteLine("DA : " + DA);
        Console.WriteLine("Total Pay : " + TotalPay);
        Console.WriteLine("Tax : " + Tax);
        Console.WriteLine("Net Pay : " + NetPay);
    }
}