using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 66. Program to find frequency of characters
// Generated as a standalone sample file.
public class Problem066
{
    public static async Task Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine() ?? "";
        foreach (var item in text.GroupBy(ch => ch).OrderBy(g => g.Key))
        {
            Console.WriteLine($"{item.Key} : {item.Count()}");
        }

        await Task.CompletedTask;
    }
}
