using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 13. Program to reverse a number
// Generated as a standalone sample file.
public class Problem013
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        int reversed = 0;
        int value = Math.Abs(n);
        while (value > 0)
        {
            reversed = reversed * 10 + value % 10;
            value /= 10;
        }
        Console.WriteLine($"Reversed = {(n < 0 ? -reversed : reversed)}");

        await Task.CompletedTask;
    }
}
