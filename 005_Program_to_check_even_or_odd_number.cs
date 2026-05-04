using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 5. Program to check even or odd number
// Generated as a standalone sample file.
public class Problem005
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");

        await Task.CompletedTask;
    }
}
