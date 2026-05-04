using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 51. Program to read and display array elements
// Generated as a standalone sample file.
public class Problem051
{
    public static async Task Main()
    {
        Console.Write("Enter numbers separated by spaces: ");
        int[] numbers = (Console.ReadLine() ?? "")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Console.WriteLine("Array elements:");
        foreach (int number in numbers) Console.WriteLine(number);

        await Task.CompletedTask;
    }
}
