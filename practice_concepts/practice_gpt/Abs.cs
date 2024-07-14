public abstract class Employee
{
    public abstract void CalculateSalary();
}



public class FullTimeEmployee : Employee
{
    private float _Salary;

    public override void CalculateSalary()
    {
        _Salary = 80000;
        Console.WriteLine($"The Salry of full time emp - {_Salary}");
    }


}


public class PartTimeEmployee : Employee
{
    private float _Salary;

    public override void CalculateSalary()
    {
        _Salary = 50000;
        Console.WriteLine($"The Salry of part time emp - {_Salary}");
    }


}