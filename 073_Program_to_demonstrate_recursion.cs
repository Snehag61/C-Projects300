using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 73. Program to demonstrate recursion
// Generated as a standalone sample file.
public class Problem073
{
    public static async Task Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Sum = {Sum(n)}");
        
        static int Sum(int n) => n <= 0 ? 0 : n + Sum(n - 1);

        await Task.CompletedTask;
    }
}
