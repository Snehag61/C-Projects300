using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 62. Program to count vowels in a string
// Generated as a standalone sample file.
public class Problem062
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        int count = text.Count(ch => "aeiouAEIOU".Contains(ch));
        Console.WriteLine($"Vowel count = {count}");

        await Task.CompletedTask;
    }
}
