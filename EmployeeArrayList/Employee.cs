using System;

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        EmployeeID = id;
        EmployeeName = name;
        Salary = salary;
    }
}