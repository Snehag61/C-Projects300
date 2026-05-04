using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 20. Program to check prime number
// Generated as a standalone sample file.
public class Problem020
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        bool isPrime = n > 1;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) { isPrime = false; break; }
        }
        Console.WriteLine(isPrime ? "Prime" : "Not prime");

        await Task.CompletedTask;
    }
}
