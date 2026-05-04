using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 77. Program to demonstrate params keyword
// Generated as a standalone sample file.
public class Problem077
{
    public static async Task Main()
    {
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine($"Total = {total}");
        
        static int Sum(params int[] numbers) => numbers.Sum();

        await Task.CompletedTask;
    }
}
