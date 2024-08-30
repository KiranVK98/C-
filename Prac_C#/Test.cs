using System;
public class Test 
{
    public void SayHello()
    {
        Console.WriteLine("Test hello");
    }
}


public class Test1 : Test
{
    public void SayHello()
    {
        Console.WriteLine("Test1 hello");
    }

    public void q()
    {
        Console.WriteLine("Q");
    }
}