// See https://aka.ms/new-console-template for more information
using System;

// Interface IPayable with CalculatePay method
public interface IPayable
{
    double CalculatePay();
}

// Base Person class
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

// Derived HourlyEmployee class implements IPayable
class HourlyEmployee : Person, IPayable
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

    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }
}

// Derived PermanentEmployee class implements IPayable
class PermanentEmployee : Person, IPayable
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }

    public PermanentEmployee(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                             double hra, double da, double tax, double netPay)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
        NetPay = netPay;
    }

    public double CalculatePay()
    {
        return (HRA + DA + NetPay) - Tax;
    }
}

// Main method for testing
class Program
{
    static void Main(string[] args)
    {
        // Instantiate and test HourlyEmployee
        IPayable hourlyEmp = new HourlyEmployee("John", "Smith", "john.smith@email.com",
                                                new DateTime(1995, 7, 12), 45, 500);
        Console.WriteLine("Hourly Employee Pay: " + hourlyEmp.CalculatePay());

        // Instantiate and test PermanentEmployee
        IPayable permEmp = new PermanentEmployee("Sara", "Park", "sara.park@email.com",
                                                 new DateTime(1987, 4, 5), 3000, 2000, 800, 6000);
        Console.WriteLine("Permanent Employee Pay: " + permEmp.CalculatePay());
    }
}
