class BankAccount
{
    private double balance;

    public void Deposit(double value)
    {
        balance += value;
    }

    public void Withdraw(double value)
    {
        if (value <= balance)
        {
            balance -= value;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public double CheckBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new();
        Console.WriteLine($"Current balance: {account.CheckBalance()}");
        account.Deposit(1000);
        Console.WriteLine($"Current balance: {account.CheckBalance()}");
        account.Withdraw(500);
        Console.WriteLine($"Current balance: {account.CheckBalance()}");
    }
}
