// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] args)
    {
        BankAccount ba = new BankAccount();

        ba.CreateBankAccount("Kiran Kulkarni" , "123456");

        ba.Deposit(40000);

        ba.DisplayAccountInfo();

        ba.Withdraw(35000);

        ba.DisplayAccountInfo();
    }
}
