using System;

class Bank
{
    double balance = 10000;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient Balance");
    }

    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        Bank b = new Bank();

        b.ShowBalance();

        b.Deposit(5000);

        b.Withdraw(2000);

        b.ShowBalance();
    }
}