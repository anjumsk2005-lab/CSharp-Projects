using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }
}

class EmployeeData
{
    public List<Employee> EmployeeInfo { get; set; }

    public EmployeeData()
    {
        EmployeeInfo = new List<Employee>();
    }

    public void ReadEmployeeDetails()
    {
        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string filePath = "EmployeeDetails.csv";

        StreamWriter writer = new StreamWriter(filePath, true);

        for (int i = 0; i < n; i++)
        {
            Employee emp = new Employee();

            Console.WriteLine("\nEnter Employee " + (i + 1) + " Details");

            Console.Write("Employee ID: ");
            emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.Write("Designation: ");
            emp.Designation = Console.ReadLine();

            Console.Write("Joining Date (dd-MM-yyyy): ");
            emp.JoiningDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Department Name: ");
            emp.DepartmentName = Console.ReadLine();

            EmployeeInfo.Add(emp);

            writer.WriteLine(
                emp.EmployeeID + "," +
                emp.EmployeeName + "," +
                emp.Designation + "," +
                emp.JoiningDate.ToShortDateString() + "," +
                emp.DepartmentName
            );
        }

        writer.Close();

        Console.WriteLine("\nEmployee details saved successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeData data = new EmployeeData();
        data.ReadEmployeeDetails();
    }
}