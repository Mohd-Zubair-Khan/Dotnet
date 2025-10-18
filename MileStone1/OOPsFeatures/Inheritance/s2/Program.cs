// See https://aka.ms/new-console-template for more information
using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    public string FirstName { get { return firstName; } }
    public string LastName { get { return lastName; } }
    public string EmailAddress { get { return emailAddress; } }
    public DateTime DateOfBirth { get { return dateOfBirth; } }
}

// Derived class: HourlyEmployee
class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                          double hoursWorked, double payPerHour)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double GetTotalPay()
    {
        return HoursWorked * PayPerHour;
    }
}

// Derived class: PermanentEmployee
class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public double TotalPay { get; set; }

    public PermanentEmployee(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                             double hra, double da, double tax, double netPay, double totalPay)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
        NetPay = netPay;
        TotalPay = totalPay;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test HourlyEmployee
        HourlyEmployee hourlyEmp = new HourlyEmployee("John", "Smith", "john.smith@email.com",
                                                      new DateTime(1995, 7, 12), 40, 500);
        Console.WriteLine("Hourly Employee: " + hourlyEmp.FirstName + " " + hourlyEmp.LastName);
        Console.WriteLine("Hours Worked: " + hourlyEmp.HoursWorked);
        Console.WriteLine("Pay Per Hour: " + hourlyEmp.PayPerHour);
        Console.WriteLine("Total Pay: " + hourlyEmp.GetTotalPay());
        Console.WriteLine();

        // Test PermanentEmployee
        PermanentEmployee permEmp = new PermanentEmployee("Sara", "Park", "sara.park@email.com",
                                                          new DateTime(1987, 4, 5), 3000, 2000, 800, 6000, 9000);
        Console.WriteLine("Permanent Employee: " + permEmp.FirstName + " " + permEmp.LastName);
        Console.WriteLine("HRA: " + permEmp.HRA);
        Console.WriteLine("DA: " + permEmp.DA);
        Console.WriteLine("Tax: " + permEmp.Tax);
        Console.WriteLine("Net Pay: " + permEmp.NetPay);
        Console.WriteLine("Total Pay: " + permEmp.TotalPay);
    }
}
