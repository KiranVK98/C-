


public delegate int Integer_Computation(int N1, int N2);


public class TestDelegate
{
    public int N1{get; set;}
    public int N2{get; set;}

    public static int AddN(int n1, int n2)
    {
        Console.WriteLine($"Resut of Addition - {n1+n2}");
        return n1+n2;
    }

    public static int MulN(int n1, int n2)
    {
        Console.WriteLine($"Resut of Multiplication - {n1*n2}");
        return n1*n2;
    }

    public static void Compute(List<TestDelegate> inp, Integer_Computation delegates)
    {
        foreach(TestDelegate numbers in inp)
        {
           delegates(numbers.N1, numbers.N2);
        }
    }
}