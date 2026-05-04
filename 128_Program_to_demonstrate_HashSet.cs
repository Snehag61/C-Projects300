using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 128. Program to demonstrate HashSet
// Generated as a standalone sample file.
public class Problem128
{
    public static async Task Main()
    {
        HashSet<int> set = [1, 2, 2, 3, 4, 4, 5];
        Console.WriteLine(string.Join(", ", set));

        await Task.CompletedTask;
    }
}
