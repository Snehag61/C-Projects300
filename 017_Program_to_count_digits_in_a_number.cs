using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 17. Program to count digits in a number
// Generated as a standalone sample file.
public class Problem017
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        string text = (Console.ReadLine() ?? "0").TrimStart('-');
        Console.WriteLine($"Digit count = {text.Length}");

        await Task.CompletedTask;
    }
}
