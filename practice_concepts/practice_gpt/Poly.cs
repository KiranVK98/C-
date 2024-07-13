public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw");
    }
}


public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Circle drawing");
    }

    public void Test()
    {
        Console.WriteLine("Hmm");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Square drawing");
    }

    public void Test()
    {
        Console.WriteLine("Hmm");
    }
}