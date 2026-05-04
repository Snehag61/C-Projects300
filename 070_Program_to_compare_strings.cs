using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 70. Program to compare strings
// Generated as a standalone sample file.
public class Problem070
{
    public static async Task Main()
    {
        Console.Write("First string: ");
        string a = Console.ReadLine() ?? "";
        Console.Write("Second string: ");
        string b = Console.ReadLine() ?? "";
        Console.WriteLine(string.Equals(a, b, StringComparison.OrdinalIgnoreCase)
            ? "Strings are equal (ignore case)"
            : "Strings are not equal");

        await Task.CompletedTask;
    }
}
