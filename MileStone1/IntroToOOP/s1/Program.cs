using System;

class Employee
{
    public string EmployeeName { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal HRA { get; private set; }
    public decimal DA { get; private set; }
    public decimal GrossPay { get; private set; }
    public decimal Tax { get; private set; }
    public decimal NetPay { get; private set; }

    public Employee(string name, decimal basicSalary)
    {
        EmployeeName = name;
        BasicSalary = basicSalary;
        CalculateNetPay();
    }

    public void CalculateNetPay()
    {
        HRA = BasicSalary * 0.15m;
        DA = BasicSalary * 0.10m;
        GrossPay = BasicSalary + HRA + DA;
        Tax = GrossPay * 0.08m;
        NetPay = GrossPay - Tax;
    }

    public void Display()
    {
        Console.WriteLine("Employee Name: " + EmployeeName);
        Console.WriteLine("Basic Salary: " + BasicSalary);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("Gross Pay: " + GrossPay);
        Console.WriteLine("Tax: " + Tax);
        Console.WriteLine("Net Pay: " + NetPay);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Alice", 40000);
        emp.Display();
    }
}
