using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 56. Program to merge two arrays
// Generated as a standalone sample file.
public class Problem056
{
    public static async Task Main()
    {
        Console.Write("First array: ");
        int[] first = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.Write("Second array: ");
        int[] second = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.WriteLine(string.Join(", ", first.Concat(second)));

        await Task.CompletedTask;
    }
}
