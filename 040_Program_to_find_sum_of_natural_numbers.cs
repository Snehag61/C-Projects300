using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 40. Program to find sum of natural numbers
// Generated as a standalone sample file.
public class Problem040
{
    public static async Task Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Sum = {n * (n + 1) / 2}");

        await Task.CompletedTask;
    }
}
