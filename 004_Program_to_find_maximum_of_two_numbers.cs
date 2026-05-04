using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 4. Program to find maximum of two numbers
// Generated as a standalone sample file.
public class Problem004
{
    public static async Task Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Maximum = {Math.Max(a, b)}");

        await Task.CompletedTask;
    }
}
