using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 23. Program to calculate area of circle
// Generated as a standalone sample file.
public class Problem023
{
    public static async Task Main()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Area = {Math.PI * r * r:F2}");

        await Task.CompletedTask;
    }
}
