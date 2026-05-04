using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 84. Program to check anagram strings
// Generated as a standalone sample file.
public class Problem084
{
    public static async Task Main()
    {
        Console.Write("First string: ");
        string a = Normalize(Console.ReadLine() ?? "");
        Console.Write("Second string: ");
        string b = Normalize(Console.ReadLine() ?? "");
        Console.WriteLine(a == b ? "Anagrams" : "Not anagrams");
        
        static string Normalize(string text) =>
            string.Concat(text.ToLowerInvariant().Where(char.IsLetterOrDigit).OrderBy(ch => ch));

        await Task.CompletedTask;
    }
}
