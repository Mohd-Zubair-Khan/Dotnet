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

public class Program
{
    public static void Main(string[] args)
    {
        // SortedList: EmployeeID as key, Employee object as value
        SortedList<int, Employee> employees = new SortedList<int, Employee>();

        // Add employees
        employees.Add(101, new Employee(101, "Alice", 70000));
        employees.Add(105, new Employee(105, "Bob", 65000));
        employees.Add(102, new Employee(102, "Charlie", 80000));

        // Display all employees (sorted by EmployeeID)
        Console.WriteLine("All Employees (SortedList):");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"ID: {kvp.Value.EmployeeID}, Name: {kvp.Value.EmployeeName}, Salary: {kvp.Value.Salary}");
        }

        // Search employee by ID
        int searchId = 102;
        if (employees.ContainsKey(searchId))
            Console.WriteLine($"Found Employee: {employees[searchId].EmployeeName}");
        else
            Console.WriteLine("Employee not found.");

        // Remove employee by ID
        int removeId = 101;
        bool removed = employees.Remove(removeId);
        Console.WriteLine($"Removed Employee ID {removeId}: {removed}");

        // Print after removal
        Console.WriteLine("Employees after deletion:");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"ID: {kvp.Value.EmployeeID}, Name: {kvp.Value.EmployeeName}, Salary: {kvp.Value.Salary}");
        }
    }
}
