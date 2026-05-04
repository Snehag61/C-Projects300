using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 6. Program to check positive or negative number
// Generated as a standalone sample file.
public class Problem006
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        double n = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine(n > 0 ? "Positive" : n < 0 ? "Negative" : "Zero");

        await Task.CompletedTask;
    }
}
