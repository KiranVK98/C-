public class Employee
{
    public string firstName;

    public string lastName;

    public Employee()
    {}

    public Employee(string message)
    {
        Console.WriteLine(message);
    }

    public void print_fullName()
    {
        Console.WriteLine($"Hello {firstName+ " " + lastName}");
    }


}


public class fullTime : Employee
{
    float yearlySalary;
    public fullTime(string firstName, string lastName, float yearlySalary, string message) : base(message)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.yearlySalary = yearlySalary;
    }

    public void print_Salary()
    {
        Console.WriteLine($"Hello {this.lastName} your present pay is {yearlySalary}$");
    }
}


public class partTime : Employee
{
    float partTimeSal;

    public partTime(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}