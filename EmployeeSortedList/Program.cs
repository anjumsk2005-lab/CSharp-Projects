using System;

class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee(103, "Anjum", 45000));
        dal.AddEmployee(new Employee(101, "Rahul", 50000));
        dal.AddEmployee(new Employee(102, "Priya", 60000));

        Console.WriteLine("Employees");

        foreach (Employee e in dal.GetAllEmployees())
        {
            Console.WriteLine(e.EmployeeID + " " +
                              e.EmployeeName + " " +
                              e.Salary);
        }

        Console.WriteLine();

        Console.WriteLine("Search Employee 102");

        Console.WriteLine(dal.SearchEmployee(102));

        Console.WriteLine();

        Console.WriteLine("Delete Employee 101");

        dal.DeleteEmployee(101);

        Console.WriteLine();

        foreach (Employee e in dal.GetAllEmployees())
        {
            Console.WriteLine(e.EmployeeID + " " +
                              e.EmployeeName + " " +
                              e.Salary);
        }
    }
}