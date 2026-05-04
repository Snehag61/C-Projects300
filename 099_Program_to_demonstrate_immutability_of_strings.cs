using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 99. Program to demonstrate immutability of strings
// Generated as a standalone sample file.
public class Problem099
{
    public static async Task Main()
    {
        string text = "Hello";
        string changed = text.Replace("H", "Y");
        Console.WriteLine($"Original: {text}");
        Console.WriteLine($"Changed : {changed}");

        await Task.CompletedTask;
    }
}
