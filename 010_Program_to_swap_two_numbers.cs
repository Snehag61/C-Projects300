using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 10. Program to swap two numbers
// Generated as a standalone sample file.
public class Problem010
{
    public static async Task Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine() ?? "0");
        (a, b) = (b, a);
        Console.WriteLine($"After swap: a = {a}, b = {b}");

        await Task.CompletedTask;
    }
}
