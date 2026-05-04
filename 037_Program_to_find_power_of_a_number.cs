using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 37. Program to find power of a number
// Generated as a standalone sample file.
public class Problem037
{
    public static async Task Main()
    {
        Console.Write("Base: ");
        double number = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Exponent: ");
        double exponent = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Result = {Math.Pow(number, exponent)}");

        await Task.CompletedTask;
    }
}
