using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 7. Program to calculate simple interest
// Generated as a standalone sample file.
public class Problem007
{
    public static async Task Main()
    {
        Console.Write("Principal: ");
        double p = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Rate: ");
        double r = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Time: ");
        double t = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Simple Interest = {(p * r * t) / 100:F2}");

        await Task.CompletedTask;
    }
}
