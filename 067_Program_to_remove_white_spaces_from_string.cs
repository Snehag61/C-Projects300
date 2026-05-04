using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 67. Program to remove white spaces from string
// Generated as a standalone sample file.
public class Problem067
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine(text.Replace(" ", ""));

        await Task.CompletedTask;
    }
}
