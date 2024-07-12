public interface test
{
    void Compute(int n1, int n2);
}


public interface test_multiply
{
    void Compute_multiply(int n1, int n2);
}

public class meth : test, test_multiply
{
    private int _Add;
    private int _Mul;

    public void Compute(int n1, int n2)
    {
        _Add = n1 + n2;
        Console.WriteLine($"Add - {_Add}");
    }

    public void Compute_multiply(int n1, int n2)
    {
        _Mul = n1 * n2;
        Console.WriteLine($"Mul - {_Mul}");
    }
}