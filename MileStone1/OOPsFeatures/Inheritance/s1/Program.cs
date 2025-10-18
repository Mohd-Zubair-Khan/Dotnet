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

    // Computed property: IsAdult
    public bool IsAdult
    {
        get
        {
            return (DateTime.Now.Year - dateOfBirth.Year -
                    (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear ? 1 : 0)) >= 18;
        }
    }

    // Computed property: SunSign (simple version using month only)
    public string SunSign
    {
        get
        {
            int month = dateOfBirth.Month;
            if (month == 3) return "Pisces";
            if (month == 4) return "Aries";
            if (month == 5) return "Taurus";
            if (month == 6) return "Gemini";
            if (month == 7) return "Cancer";
            if (month == 8) return "Leo";
            if (month == 9) return "Virgo";
            if (month == 10) return "Libra";
            if (month == 11) return "Scorpio";
            if (month == 12) return "Sagittarius";
            if (month == 1) return "Capricorn";
            if (month == 2) return "Aquarius";
            return "Unknown";
        }
    }

    // Computed property: IsBirthDay
    public bool IsBirthDay
    {
        get
        {
            DateTime today = DateTime.Today;
            return today.Month == dateOfBirth.Month && today.Day == dateOfBirth.Day;
        }
    }

    // Computed property: ScreenName
    public string ScreenName
    {
        get
        {
            return firstName.ToLower() + lastName.ToLower() + dateOfBirth.ToString("ddMMyyyy");
        }
    }
}
class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, double salary)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        Salary = salary;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Sample Employee
        Employee emp = new Employee("Hari", "Doe", "haridoe@gmail.com", new DateTime(1980, 5, 25), 75000);

        Console.WriteLine("First Name: " + emp.FirstName);
        Console.WriteLine("Last Name: " + emp.LastName);
        Console.WriteLine("Email: " + emp.EmailAddress);
        Console.WriteLine("Date of Birth: " + emp.DateOfBirth.ToShortDateString());
        Console.WriteLine("Salary: " + emp.Salary);
        Console.WriteLine("Is Adult: " + emp.IsAdult);
        Console.WriteLine("Sun Sign: " + emp.SunSign);
        Console.WriteLine("Is BirthDay: " + emp.IsBirthDay);
        Console.WriteLine("Screen Name: " + emp.ScreenName);
    }
}
