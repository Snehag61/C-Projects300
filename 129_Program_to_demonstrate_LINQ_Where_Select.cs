using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 129. Program to demonstrate LINQ (Where, Select)
// Generated as a standalone sample file.
public class Problem129
{
    public static async Task Main()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6];
        var result = numbers.Where(n => n % 2 == 0).Select(n => n * n);
        Console.WriteLine(string.Join(", ", result));

        await Task.CompletedTask;
    }
}
