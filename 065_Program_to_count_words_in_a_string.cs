using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 65. Program to count words in a string
// Generated as a standalone sample file.
public class Problem065
{
    public static async Task Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine() ?? "";
        int words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"Word count = {words}");

        await Task.CompletedTask;
    }
}
