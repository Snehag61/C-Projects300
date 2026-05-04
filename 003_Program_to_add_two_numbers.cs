using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 3. Program to add two numbers
// Generated as a standalone sample file.
public class Problem003
{
    public static async Task Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Sum = {a + b}");

        await Task.CompletedTask;
    }
}
