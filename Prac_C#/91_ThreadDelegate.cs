
public delegate void PrintSumDelegate(int sum);


public class TestThread
{
    public static void PrintSum(int sum)
    {
        Console.WriteLine(sum);
    }

    public void sumThread()
    {
        
        Console.WriteLine("Enter target number");
        int target = Convert.ToInt32(Console.ReadLine());

        PrintSumDelegate pc = new PrintSumDelegate(PrintSum);

        compute sumCompute = new compute(target, pc);
        
        Thread t1 = new Thread(new ThreadStart(sumCompute.ComputeSum));

        t1.Start();


    }

}

public class compute
{
    int _Target;
    int sum =0;
    PrintSumDelegate _Pc;
    public compute(int target, PrintSumDelegate pc)
    {
        this._Pc = pc;
        this._Target = target;
    }

    public void ComputeSum()
    {
        for(int i = 1; i <= _Target; i++)
        {
            sum += i;
        }

        _Pc(sum);
    }
}
