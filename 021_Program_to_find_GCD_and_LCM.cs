using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 21. Program to find GCD and LCM
// Generated as a standalone sample file.
public class Problem021
{
    public static async Task Main()
    {
        Console.Write("Enter two numbers separated by spaces: ");
        int[] parts = (Console.ReadLine() ?? "")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int a = parts[0], b = parts[1];
        int x = a, y = b;
        while (y != 0) (x, y) = (y, x % y);
        int gcd = Math.Abs(x);
        int lcm = Math.Abs(a * b) / gcd;
        Console.WriteLine($"GCD = {gcd}, LCM = {lcm}");

        await Task.CompletedTask;
    }
}
