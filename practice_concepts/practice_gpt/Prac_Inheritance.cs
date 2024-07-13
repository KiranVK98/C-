public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}


public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

