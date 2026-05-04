using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 24. Program to calculate area of rectangle
// Generated as a standalone sample file.
public class Problem024
{
    public static async Task Main()
    {
        Console.Write("Enter length: ");
        double l = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter breadth: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Area = {l * b:F2}");

        await Task.CompletedTask;
    }
}
