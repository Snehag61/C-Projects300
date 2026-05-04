using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 18. Program to print multiplication table
// Generated as a standalone sample file.
public class Problem018
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

        await Task.CompletedTask;
    }
}
