using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 119. Program to demonstrate SOLID principles (examples)
// Generated as a standalone sample file.
public class Problem119
{
    public static async Task Main()
    {
        IInvoiceCalculator calculator = new StandardInvoiceCalculator();
        Console.WriteLine($"Total = {calculator.Calculate(1000, 0.18m)}");
        
        // S: Single responsibility -> only invoice calculation
        // O: Open/closed -> new calculators can be added without changing caller
        // L: Liskov substitution -> implementations can replace the interface
        // I: Interface segregation -> small focused interface
        // D: Dependency inversion -> caller depends on abstraction

        await Task.CompletedTask;
    }
}

interface IInvoiceCalculator { decimal Calculate(decimal amount, decimal taxRate); }
class StandardInvoiceCalculator : IInvoiceCalculator
{
    public decimal Calculate(decimal amount, decimal taxRate) => amount + (amount * taxRate);
}