using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 74. Program to generate Fibonacci using recursion
// Generated as a standalone sample file.
public class Problem074
{
    public static async Task Main()
    {
        Console.Write("How many terms? ");
        int terms = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(Fibonacci(i) + (i == terms - 1 ? "" : ", "));
        }
        
        static int Fibonacci(int n) => n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

        await Task.CompletedTask;
    }
}
