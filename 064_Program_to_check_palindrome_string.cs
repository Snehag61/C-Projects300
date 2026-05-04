using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 64. Program to check palindrome string
// Generated as a standalone sample file.
public class Problem064
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = (Console.ReadLine() ?? "").Replace(" ", "").ToLowerInvariant();
        string reversed = new(text.Reverse().ToArray());
        Console.WriteLine(text == reversed ? "Palindrome" : "Not a palindrome");

        await Task.CompletedTask;
    }
}
