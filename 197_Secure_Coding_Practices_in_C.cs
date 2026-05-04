using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 197. Secure Coding Practices in C#
// Generated as a standalone sample file.
public class Problem197
{
    public static async Task Main()
    {
        Console.WriteLine("Secure coding sample:");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input required.");
            return;
        }
        
        string safe = Regex.Replace(input, "[^a-zA-Z0-9 ]", "");
        Console.WriteLine(safe);

        await Task.CompletedTask;
    }
}
