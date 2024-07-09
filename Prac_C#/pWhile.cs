using Microsoft.VisualBasic;

public class pWhile
{
    public void prac_while()
    {
        
        int totalCost = 0;
        Console.WriteLine("Enter the size of coffee to buy - 1. Small, 2. Medium, 3. Large");

        string new_choice;

        string choice = Console.ReadLine();

        do{
        

        int size_coffee = int.Parse(choice);

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
                break;
        }

        Console.WriteLine(@"Do you want to buy another coffee? Answer ""Yes"" or ""No"" ");

        new_choice = Console.ReadLine();
        do{
        
        if(new_choice == "Yes")
        {
            Console.WriteLine("Enter the size of coffee to buy - 1. Small, 2. Medium, 3. Large");
            choice = Console.ReadLine();
        }

        }while(new_choice!="Yes" && new_choice!="No");

        
    }while(new_choice=="Yes");

    Console.WriteLine($"Your total bill for today is {totalCost}");

    }
}
