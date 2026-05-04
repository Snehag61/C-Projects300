using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 9. Program to find largest of three numbers
// Generated as a standalone sample file.
public class Problem009
{
    public static async Task Main()
    {
        Console.Write("Enter three numbers separated by spaces: ");
        double[] numbers = (Console.ReadLine() ?? "")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
        Console.WriteLine($"Largest = {numbers.Max()}");

        await Task.CompletedTask;
    }
}
