using System.Net.Http.Headers;

public class method_params 
{
    public method_params(out int j, out int Sum, out int Prod)
    {
        method_params.test_ref(out j);
        method_params.test_out(20,30, out Sum, out Prod);

    }
    public static void test_ref(out int j)
    {
        j = 200;
    }

    public static void test_out(int N1, int N2, out int Sum, out int Prod)
    {
        Sum = N1 + N2;
        Prod = N1 * N2;
    }

    public static void test_params(ref int[] Numbers)
    {
        // Console.WriteLine(Numbers.Length);

        Numbers[0] = 120;
    }
}