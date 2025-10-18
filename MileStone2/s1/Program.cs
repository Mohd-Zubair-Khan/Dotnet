// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

// Employee class
public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}

// EmployeeDAL class for collection and management
public class EmployeeDAL
{
    private ArrayList employeeList = new ArrayList();

    // Add employee
    public bool AddEmployee(Employee e)
    {
        if (e != null)
        {
            employeeList.Add(e);
            return true;
        }
        return false;
    }

    // Delete employee by ID
    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
            {
                employeeList.Remove(emp);
                return true;
            }
        }
        return false;
    }

    // Search employee by ID; return name if found, else null
    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.EmployeeID == id)
                return emp.EmployeeName;
        }
        return null;
    }

    // Return array of all employees
    public Employee[] GetAllEmployeesList()
    {
        Employee[] arr = new Employee[employeeList.Count];
        employeeList.CopyTo(arr);
        return arr;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDAL dal = new EmployeeDAL();

        // Add employees
        dal.AddEmployee(new Employee("Alice", 101, 70000));
        dal.AddEmployee(new Employee("Bob", 102, 65000));
        dal.AddEmployee(new Employee("Charlie", 103, 80000));

        // Search employee
        Console.WriteLine("Search Employee ID 102: " + dal.SearchEmployee(102));

        // Delete an employee
        Console.WriteLine("Delete Employee ID 101: " + dal.DeleteEmployee(101));

        // Print all employees
        Console.WriteLine("All Employees:");
        foreach (Employee emp in dal.GetAllEmployeesList())
        {
            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Salary: {emp.Salary}");
        }
    }
}
