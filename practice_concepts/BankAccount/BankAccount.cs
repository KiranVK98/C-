class BankAccount
{
    private string _AccountNumber;

    private string _AccountName;

    private decimal _Balance;


    public void CreateBankAccount(string AccountName, string AccountNumber)
    {
        this._AccountName = AccountName;
        this._AccountNumber = AccountNumber;
    }
    public void Deposit(decimal Amount)
    {
        this._Balance += Amount;
    }

    public void Withdraw(decimal Amount)
    {
        this._Balance -= Amount;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account name - {_AccountName} has Balance - {_Balance}");
    }
}