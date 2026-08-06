using System;
using System.Collections;

class Employee
{
    public int EmployeeID;
    public string EmployeeName;
    public double Salary;

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
        SortedList empList = new SortedList();

        empList.Add(103, new Employee(103, "John", 50000));
        empList.Add(101, new Employee(101, "Rahul", 35000));
        empList.Add(102, new Employee(102, "Anu", 42000));

        Console.WriteLine("Employee Details");

        foreach (DictionaryEntry item in empList)
        {
            Employee e = (Employee)item.Value;
            e.Display();
        }
    }
}