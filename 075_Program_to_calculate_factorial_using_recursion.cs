using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 75. Program to calculate factorial using recursion
// Generated as a standalone sample file.
public class Problem075
{
    public static async Task Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine(Factorial(n));
        
        static long Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);

        await Task.CompletedTask;
    }
}
