// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;

// Employee class with auto-implemented properties
public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }
}

// EmployeeDAL with auto-implemented List
public class EmployeeDAL
{
    public List<Employee> EmployeeInfo { get; set; } = new List<Employee>();

    // Add employee and persist to CSV, reading old records first
    public void AddEmployeeAndSave(Employee emp, string csvFilePath)
    {
        if (File.Exists(csvFilePath))
        {
            using (var reader = new StreamReader(csvFilePath))
            {
                string header = reader.ReadLine(); // skip header
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var parts = line.Split(',');
                    Employee existing = new Employee
                    {
                        EmployeeID = int.Parse(parts[0]),
                        EmployeeName = parts[1],
                        Designation = parts[2],
                        JoiningDate = DateTime.Parse(parts[3]),
                        DepartmentName = parts[4]
                    };
                    if (!EmployeeInfo.Exists(e => e.EmployeeID == existing.EmployeeID))
                        EmployeeInfo.Add(existing);
                }
            }
        }

        if (!EmployeeInfo.Exists(e => e.EmployeeID == emp.EmployeeID))
            EmployeeInfo.Add(emp);

        using (var writer = new StreamWriter(csvFilePath, false))
        {
            writer.WriteLine("EmployeeID,EmployeeName,Designation,JoiningDate,DepartmentName");
            foreach (var e in EmployeeInfo)
                writer.WriteLine($"{e.EmployeeID},{e.EmployeeName},{e.Designation},{e.JoiningDate},{e.DepartmentName}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDAL dal = new EmployeeDAL();
        string filePath = "employees.csv";

        // Add employees
        Employee emp1 = new Employee { EmployeeID = 201, EmployeeName = "Swati", Designation = "Developer", JoiningDate = DateTime.Now.Date, DepartmentName = "IT" };
        Employee emp2 = new Employee { EmployeeID = 202, EmployeeName = "Rohan", Designation = "Manager", JoiningDate = DateTime.Now.Date.AddMonths(-2), DepartmentName = "HR" };

        // Save and persist
        dal.AddEmployeeAndSave(emp1, filePath);
        dal.AddEmployeeAndSave(emp2, filePath);

        Console.WriteLine("Employees added and persisted in CSV file.");
    }
}
