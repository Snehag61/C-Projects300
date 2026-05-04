using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 132. Program to demonstrate LINQ (Aggregate)
// Generated as a standalone sample file.
public class Problem132
{
    public static async Task Main()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        int sum = numbers.Aggregate((a, b) => a + b);
        Console.WriteLine(sum);

        await Task.CompletedTask;
    }
}
