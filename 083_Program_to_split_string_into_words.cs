using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 83. Program to split string into words
// Generated as a standalone sample file.
public class Problem083
{
    public static async Task Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine() ?? "";
        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            Console.WriteLine(word);
        }

        await Task.CompletedTask;
    }
}
