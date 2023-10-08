using System;
public class BankAccount
{
    private decimal balance;
    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be set to a negative value.");
            }
            else
            {
                balance = value;
            }
        }
    }
    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient balance for withdrawal.");
        }
        Balance -= amount;
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: ${Balance}");
    }
}
class Program
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(1000.0m);
            account.DisplayBalance();
            account.Deposit(500.0m);
            account.DisplayBalance();
            account.Withdraw(300.0m);
            account.DisplayBalance();
           
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}