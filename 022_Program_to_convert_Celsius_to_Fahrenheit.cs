using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 22. Program to convert Celsius to Fahrenheit
// Generated as a standalone sample file.
public class Problem022
{
    public static async Task Main()
    {
        Console.Write("Enter Celsius: ");
        double c = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Fahrenheit = {(c * 9 / 5) + 32:F2}");

        await Task.CompletedTask;
    }
}
