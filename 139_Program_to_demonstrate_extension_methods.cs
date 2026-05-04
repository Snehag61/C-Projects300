using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 139. Program to demonstrate extension methods
// Generated as a standalone sample file.
public class Problem139
{
    public static async Task Main()
    {
        string text = "hello world";
        Console.WriteLine(text.ToTitleCase());

        await Task.CompletedTask;
    }
}

static class StringExtensions
{
    public static string ToTitleCase(this string value) =>
        string.Join(' ', value.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => char.ToUpper(word[0]) + word[1..].ToLower()));
}