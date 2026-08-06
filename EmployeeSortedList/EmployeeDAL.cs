using System;
using System.Collections;

class EmployeeDAL
{
    SortedList employees = new SortedList();

    public bool AddEmployee(Employee e)
    {
        employees.Add(e.EmployeeID, e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            employees.Remove(id);
            return true;
        }

        return false;
    }

    public string SearchEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            Employee e = (Employee)employees[id];
            return e.EmployeeName;
        }

        return null;
    }

    public Employee[] GetAllEmployees()
    {
        Employee[] emp = new Employee[employees.Count];

        for (int i = 0; i < employees.Count; i++)
        {
            emp[i] = (Employee)employees.GetByIndex(i);
        }

        return emp;
    }
}