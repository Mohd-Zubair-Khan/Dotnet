// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// Employee class
public class Employee
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

// Employee list operations
public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        // Add employees
        employees.Add(new Employee(101, "Alice", 70000));
        employees.Add(new Employee(105, "Bob", 65000));
        employees.Add(new Employee(102, "Charlie", 80000));

        // Display all employees
        Console.WriteLine("All Employees (List):");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Salary: {emp.Salary}");
        }

        // Search employee by ID
        int searchId = 102;
        var foundEmp = employees.Find(e => e.EmployeeID == searchId);
        if (foundEmp != null)
            Console.WriteLine($"Found Employee: {foundEmp.EmployeeName}");
        else
            Console.WriteLine("Employee not found.");

        // Remove employee by ID
        int removeId = 101;
        Employee toRemove = employees.Find(e => e.EmployeeID == removeId);
        bool removed = false;
        if (toRemove != null)
        {
            employees.Remove(toRemove);
            removed = true;
        }
        Console.WriteLine($"Removed Employee ID {removeId}: {removed}");

        // Print after removal
        Console.WriteLine("Employees after deletion:");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Salary: {emp.Salary}");
        }
    }
}
