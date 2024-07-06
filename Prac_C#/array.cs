public class array  // Collection of similar data types with fixed size
{
    public void test_array()
    {
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 2;
        evenNumbers[1] = 4;
        evenNumbers[2] = 6;

        foreach(var number in evenNumbers)
        {
            Console.WriteLine(number);
        } 
    }
}