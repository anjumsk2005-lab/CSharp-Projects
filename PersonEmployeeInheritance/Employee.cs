using System;

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email, DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }
}