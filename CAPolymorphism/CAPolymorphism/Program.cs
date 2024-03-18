using System;

// Base class for Account
public class Account
{
    protected double balance;  // Current balance

    // Constructor to initialize the balance
    public Account(double initialBalance)
    {
        balance = initialBalance;
    }

    // Method to deposit funds
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}, Current Balance: {balance}");
    }

    // Virtual method to withdraw funds
    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Current Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}

// Subclass for Savings Account
public class SavingsAccount : Account
{
    private double minBalance;  // Minimum balance required

    // Constructor to initialize minimum balance
    public SavingsAccount(double initialBalance, double minBalance) : base(initialBalance)
    {
        this.minBalance = minBalance;
    }

    // Override withdraw method to implement specific rules for Savings Account
    public override void Withdraw(double amount)
    {
        if (amount <= balance && balance - amount >= minBalance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Current Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or below minimum balance!");
        }
    }
}

// Subclass for Current Account
public class CurrentAccount : Account
{
    // Constructor
    public CurrentAccount(double initialBalance) : base(initialBalance)
    {
    }

    // No need to override Withdraw method as there are no specific rules for Current Account
}

// Subclass for Fixed Deposit Account
public class FixedDepositAccount : Account
{
    private double penalty;  // Penalty for early withdrawal

    // Constructor to initialize penalty
    public FixedDepositAccount(double initialBalance, double penalty) : base(initialBalance)
    {
        this.penalty = penalty;
    }

    // Override withdraw method to implement specific rules for Fixed Deposit Account
    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Current Balance: {balance}");
        }
        else
        {
            Console.WriteLine($"Insufficient funds! Penalty of {penalty} applied.");
            balance -= penalty;
            Console.WriteLine($"Current Balance: {balance}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different account types
        Account savingsAccount = new SavingsAccount(1000, 500);
        Account currentAccount = new CurrentAccount(2000);
        Account fixedDepositAccount = new FixedDepositAccount(5000, 100);

        // Performing transactions
        savingsAccount.Deposit(500);
        savingsAccount.Withdraw(300);
        savingsAccount.Withdraw(800);

        currentAccount.Deposit(1000);
        currentAccount.Withdraw(1500);

        fixedDepositAccount.Deposit(2000);
        fixedDepositAccount.Withdraw(4000);
    }
}