using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 14. Program to check palindrome number
// Generated as a standalone sample file.
public class Problem014
{
    public static async Task Main()
    {
        Console.Write("Enter a number: ");
        string text = Console.ReadLine() ?? "";
        string reversed = new(text.Reverse().ToArray());
        Console.WriteLine(text == reversed ? "Palindrome" : "Not a palindrome");

        await Task.CompletedTask;
    }
}
