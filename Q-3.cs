using System;
class BankAccount
{
    private string customerName;
    private decimal accountBalance;
    public BankAccount(string name, decimal initialBalance)
    {
        customerName = name;
        accountBalance = initialBalance;
    }
    public string GetCustomerName()
    {
        return customerName;
    }
    public decimal GetAccountBalance()
    {
        return accountBalance;
    }
    public bool WithdrawFunds(decimal amount)
    {
        if (amount > 0 && amount <= accountBalance)
        {
            accountBalance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("vaishnavi", 1000.0m);
        Console.WriteLine($"Customer Name: {account.GetCustomerName()}");
        Console.WriteLine($"Account Balance: ${account.GetAccountBalance()}");
        decimal withdrawAmount = 500.0m;
        bool withdrawalResult = account.WithdrawFunds(withdrawAmount);
        if (withdrawalResult)
        {
            Console.WriteLine($"Withdrawal of ${withdrawAmount} successful.");
        }
        else
        {
            Console.WriteLine($"Withdrawal of ${withdrawAmount} failed.");
        }
        Console.WriteLine($"Updated Account Balance: ${account.GetAccountBalance()}");
    }
}