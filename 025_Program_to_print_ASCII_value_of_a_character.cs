using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 25. Program to print ASCII value of a character
// Generated as a standalone sample file.
public class Problem025
{
    public static async Task Main()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine($"\nASCII value = {(int)ch}");

        await Task.CompletedTask;
    }
}
