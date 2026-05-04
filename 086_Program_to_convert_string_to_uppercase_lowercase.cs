using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 86. Program to convert string to uppercase/lowercase
// Generated as a standalone sample file.
public class Problem086
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine(text.ToUpperInvariant());
        Console.WriteLine(text.ToLowerInvariant());

        await Task.CompletedTask;
    }
}
