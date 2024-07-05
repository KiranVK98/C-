using System;
public class Test 
{
    public void SayHello()
    {
        Console.WriteLine("Enter your first name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter your last name");
        string LastName = Console.ReadLine(); 

        Console.WriteLine("Hello {0} {1}" ,FirstName, LastName);
    }
}