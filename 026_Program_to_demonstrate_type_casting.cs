using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 26. Program to demonstrate type casting
// Generated as a standalone sample file.
public class Problem026
{
    public static async Task Main()
    {
        double value = 12.75;
        int explicitCast = (int)value;
        double implicitCast = explicitCast;
        Console.WriteLine($"Original: {value}");
        Console.WriteLine($"Explicit cast to int: {explicitCast}");
        Console.WriteLine($"Implicit cast back to double: {implicitCast}");

        await Task.CompletedTask;
    }
}
