using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 133. Program to demonstrate lambda expressions
// Generated as a standalone sample file.
public class Problem133
{
    public static async Task Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(10, 20));

        await Task.CompletedTask;
    }
}
