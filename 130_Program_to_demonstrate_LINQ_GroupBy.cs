using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 130. Program to demonstrate LINQ (GroupBy)
// Generated as a standalone sample file.
public class Problem130
{
    public static async Task Main()
    {
        string[] words = ["apple", "ant", "ball", "bat", "cat"];
        var groups = words.GroupBy(word => word[0]);
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
        }

        await Task.CompletedTask;
    }
}
