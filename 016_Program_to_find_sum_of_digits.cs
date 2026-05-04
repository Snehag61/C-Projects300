using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 16. Program to find sum of digits
// Generated as a standalone sample file.
public class Problem016
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = Math.Abs(int.Parse(Console.ReadLine() ?? "0"));
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine($"Sum of digits = {sum}");

        await Task.CompletedTask;
    }
}
