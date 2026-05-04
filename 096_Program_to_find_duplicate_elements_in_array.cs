using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 96. Program to find duplicate elements in array
// Generated as a standalone sample file.
public class Problem096
{
    public static async Task Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 5, 3, 6 };
        foreach (int item in numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key))
        {
            Console.WriteLine(item);
        }

        await Task.CompletedTask;
    }
}
