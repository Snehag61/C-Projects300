using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 110. Program to demonstrate encapsulation
// Generated as a standalone sample file.
public class Problem110
{
    public static async Task Main()
    {
        BankAccount account = new(5000);
        account.Deposit(1500);
        account.Withdraw(700);
        Console.WriteLine($"Balance = {account.Balance}");

        await Task.CompletedTask;
    }
}

class BankAccount
{
    public decimal Balance { get; private set; }
    public BankAccount(decimal balance) => Balance = balance;
    public void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) { if (amount <= Balance) Balance -= amount; }
}