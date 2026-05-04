using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 68. Program to replace substring in string
// Generated as a standalone sample file.
public class Problem068
{
    public static async Task Main()
    {
        Console.Write("Enter the original string: ");
        string text = Console.ReadLine() ?? "";
        Console.Write("Substring to replace: ");
        string oldValue = Console.ReadLine() ?? "";
        Console.Write("New substring: ");
        string newValue = Console.ReadLine() ?? "";
        Console.WriteLine(text.Replace(oldValue, newValue));

        await Task.CompletedTask;
    }
}
