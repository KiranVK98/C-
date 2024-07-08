using System.ComponentModel.DataAnnotations;

public class switch_class
{
    public void test_switch()

    {
        int totalCost = 0;

        Start:

        Console.WriteLine("Enter the size of coffee to buy - 1. Small, 2. Medium, 3. Large");

        int size_coffee = int.Parse(Console.ReadLine());

        switch(size_coffee)
        {
            case 1:
                totalCost += 1;
                break;

            case 2:
                totalCost += 2;
                break;

            case 3:
                totalCost += 3;
                break;

            default:
                Console.WriteLine($"Your choice {size_coffee} is invalid");
                goto Start;
        }

        Decide:
        Console.WriteLine(@"Do you want to buy another coffee? Answer ""Yes"" or ""No"" ");

        string decision = Console.ReadLine();

        switch(decision)
        {
            case "Yes":
                goto Start;

            case "No":
                break;

            default:
                Console.WriteLine("Invalid choice");
                goto Decide;
        }

        Console.WriteLine($"Your total bill for today is {totalCost}");
        
    }
}
