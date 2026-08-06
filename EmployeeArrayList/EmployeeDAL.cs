using System;
using System.Collections;

class EmployeeDAL
{
    ArrayList employees = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee e in employees)
        {
            if (e.EmployeeID == id)
            {
                employees.Remove(e);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee e in employees)
        {
            if (e.EmployeeID == id)
                return e.EmployeeName;
        }

        return null;
    }

    public Employee[] GetAllEmployees()
    {
        Employee[] emp = new Employee[employees.Count];

        for (int i = 0; i < employees.Count; i++)
        {
            emp[i] = (Employee)employees[i];
        }

        return emp;
    }
}