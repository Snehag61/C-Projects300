using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 11. Program to find factorial of a number
// Generated as a standalone sample file.
public class Problem011
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        long factorial = 1;
        for (int i = 2; i <= n; i++) factorial *= i;
        Console.WriteLine($"Factorial = {factorial}");

        await Task.CompletedTask;
    }
}
