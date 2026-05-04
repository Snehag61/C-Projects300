using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 63. Program to reverse a string
// Generated as a standalone sample file.
public class Problem063
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine(new string(text.Reverse().ToArray()));

        await Task.CompletedTask;
    }
}
