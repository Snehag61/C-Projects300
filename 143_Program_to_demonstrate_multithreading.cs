using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

// 143. Program to demonstrate multithreading
// Generated as a standalone sample file.
public class Problem143
{
    public static async Task Main()
    {
        Thread worker = new(() =>
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
            }
        });
        worker.Start();
        worker.Join();
        Console.WriteLine("Main thread completed.");

        await Task.CompletedTask;
    }
}
