using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 145. Program to demonstrate locking and synchronization
// Generated as a standalone sample file.
public class Problem145
{
    public static async Task Main()
    {
        Counter counter = new();
        Parallel.Invoke(
            () => counter.IncrementMany(),
            () => counter.IncrementMany(),
            () => counter.IncrementMany());
        Console.WriteLine(counter.Value);

        await Task.CompletedTask;
    }
}

class Counter
{
    private readonly object _sync = new();
    public int Value { get; private set; }
    public void IncrementMany()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (_sync) Value++;
        }
    }
}