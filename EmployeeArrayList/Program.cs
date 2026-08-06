using System;

class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee(101, "Anjum", 50000));
        dal.AddEmployee(new Employee(102, "Rahul", 45000));
        dal.AddEmployee(new Employee(103, "Priya", 60000));

        Console.WriteLine("All Employees");

        foreach (Employee e in dal.GetAllEmployees())
        {
            Console.WriteLine(e.EmployeeID + " " +
                              e.EmployeeName + " " +
                              e.Salary);
        }

        Console.WriteLine();

        Console.WriteLine("Searching Employee 102");

        Console.WriteLine(dal.SearchEmployee(102));

        Console.WriteLine();

        Console.WriteLine("Deleting Employee 101");

        dal.DeleteEmployee(101);

        Console.WriteLine();

        Console.WriteLine("Employees After Delete");

        foreach (Employee e in dal.GetAllEmployees())
        {
            Console.WriteLine(e.EmployeeID + " " +
                              e.EmployeeName + " " +
                              e.Salary);
        }
    }
}