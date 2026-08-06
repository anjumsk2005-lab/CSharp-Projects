using System;
using System.Collections.Generic;

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

    public void Display()
    {
        Console.WriteLine(EmployeeID + " " + EmployeeName + " " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee(101, "Rahul", 35000));
        empList.Add(new Employee(102, "Anu", 42000));
        empList.Add(new Employee(103, "John", 50000));

        Console.WriteLine("Employee Details");

        foreach (Employee e in empList)
        {
            e.Display();
        }
    }
}