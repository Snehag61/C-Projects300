using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 8. Program to calculate compound interest
// Generated as a standalone sample file.
public class Problem008
{
    public static async Task Main()
    {
        Console.Write("Principal: ");
        double p = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Rate: ");
        double r = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Time: ");
        double t = double.Parse(Console.ReadLine() ?? "0");
        double amount = p * Math.Pow(1 + r / 100, t);
        Console.WriteLine($"Compound Interest = {amount - p:F2}");

        await Task.CompletedTask;
    }
}
