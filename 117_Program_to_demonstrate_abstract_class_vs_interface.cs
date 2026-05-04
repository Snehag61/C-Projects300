using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 117. Program to demonstrate abstract class vs interface
// Generated as a standalone sample file.
public class Problem117
{
    public static async Task Main()
    {
        Payment card = new CardPayment();
        card.Pay(500);
        
        IRefundable refundable = new CardPayment();
        refundable.Refund(200);

        await Task.CompletedTask;
    }
}

abstract class Payment { public abstract void Pay(decimal amount); }
interface IRefundable { void Refund(decimal amount); }
class CardPayment : Payment, IRefundable
{
    public override void Pay(decimal amount) => Console.WriteLine($"Paid {amount}");
    public void Refund(decimal amount) => Console.WriteLine($"Refunded {amount}");
}