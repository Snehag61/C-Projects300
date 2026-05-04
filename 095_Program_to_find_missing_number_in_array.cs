using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 95. Program to find missing number in array
// Generated as a standalone sample file.
public class Problem095
{
    public static async Task Main()
    {
        int[] numbers = { 1, 2, 3, 5, 6 };
        int n = numbers.Length + 1;
        int expected = n * (n + 1) / 2;
        int actual = numbers.Sum();
        Console.WriteLine($"Missing number = {expected - actual}");

        await Task.CompletedTask;
    }
}
