using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 12. Program to generate Fibonacci series
// Generated as a standalone sample file.
public class Problem012
{
    public static async Task Main()
    {
        Console.Write("How many terms? ");
        int terms = int.Parse(Console.ReadLine() ?? "0");
        int a = 0, b = 1;
        List<int> series = new();
        for (int i = 0; i < terms; i++)
        {
            series.Add(a);
            (a, b) = (b, a + b);
        }
        Console.WriteLine(string.Join(", ", series));

        await Task.CompletedTask;
    }
}
