using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 94. Program to find common elements in two arrays
// Generated as a standalone sample file.
public class Problem094
{
    public static async Task Main()
    {
        int[] first = { 1, 2, 3, 4, 5 };
        int[] second = { 4, 5, 6, 7, 8 };
        Console.WriteLine(string.Join(", ", first.Intersect(second)));

        await Task.CompletedTask;
    }
}
