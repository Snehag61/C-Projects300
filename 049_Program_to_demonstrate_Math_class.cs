using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 49. Program to demonstrate Math class
// Generated as a standalone sample file.
public class Problem049
{
    public static async Task Main()
    {
        Console.WriteLine($"Sqrt(49)   = {Math.Sqrt(49)}");
        Console.WriteLine($"Pow(2, 5)  = {Math.Pow(2, 5)}");
        Console.WriteLine($"Ceiling    = {Math.Ceiling(10.2)}");
        Console.WriteLine($"Floor      = {Math.Floor(10.9)}");
        Console.WriteLine($"Round      = {Math.Round(10.56, 1)}");

        await Task.CompletedTask;
    }
}
