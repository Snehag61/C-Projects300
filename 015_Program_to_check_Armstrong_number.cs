using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 15. Program to check Armstrong number
// Generated as a standalone sample file.
public class Problem015
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        string text = Math.Abs(n).ToString();
        int power = text.Length;
        int sum = text.Sum(ch => (int)Math.Pow(ch - '0', power));
        Console.WriteLine(sum == Math.Abs(n) ? "Armstrong number" : "Not an Armstrong number");

        await Task.CompletedTask;
    }
}
