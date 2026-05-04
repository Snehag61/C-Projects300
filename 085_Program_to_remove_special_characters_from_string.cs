using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 85. Program to remove special characters from string
// Generated as a standalone sample file.
public class Problem085
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine(Regex.Replace(text, "[^a-zA-Z0-9 ]", ""));

        await Task.CompletedTask;
    }
}
