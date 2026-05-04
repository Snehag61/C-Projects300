using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 144. Program to demonstrate Task Parallel Library (TPL)
// Generated as a standalone sample file.
public class Problem144
{
    public static async Task Main()
    {
        Parallel.ForEach(Enumerable.Range(1, 5), number =>
        {
            Console.WriteLine($"Processing {number} on thread {Environment.CurrentManagedThreadId}");
        });

        await Task.CompletedTask;
    }
}
