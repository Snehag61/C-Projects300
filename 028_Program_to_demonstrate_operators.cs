using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 28. Program to demonstrate operators
// Generated as a standalone sample file.
public class Problem028
{
    public static async Task Main()
    {
        int a = 12, b = 5;
        Console.WriteLine($"Arithmetic: {a + b}, {a - b}, {a * b}, {a / b}, {a % b}");
        Console.WriteLine($"Relational: {a > b}, {a < b}, {a == b}");
        Console.WriteLine($"Logical   : {(a > 0 && b > 0)}, {(a < 0 || b > 0)}");

        await Task.CompletedTask;
    }
}
