using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 126. Program to demonstrate Dictionary
// Generated as a standalone sample file.
public class Problem126
{
    public static async Task Main()
    {
        Dictionary<int, string> students = new()
        {
            [1] = "Sneha",
            [2] = "Ravi",
            [3] = "Anu"
        };
        foreach (var item in students)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        await Task.CompletedTask;
    }
}
