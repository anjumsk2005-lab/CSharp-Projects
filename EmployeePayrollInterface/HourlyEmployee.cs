using System;

class HourlyEmployee : Person, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }
    public double TotalPay { get; set; }

    public HourlyEmployee(string firstName, string lastName, string email,
        DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public void CalculatePay()
    {
        TotalPay = HoursWorked * PayPerHour;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Hours Worked : " + HoursWorked);
        Console.WriteLine("Pay Per Hour : " + PayPerHour);
        Console.WriteLine("Total Pay : " + TotalPay);
    }
}