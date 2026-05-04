using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 100. Program to demonstrate memory management basics
// Generated as a standalone sample file.
public class Problem100
{
    public static async Task Main()
    {
        byte[] buffer = new byte[1024];
        using MemoryStream stream = new(buffer);
        stream.WriteByte(65);
        Console.WriteLine("Managed objects are cleaned up automatically by the GC.");
        Console.WriteLine($"Stream length = {stream.Length}");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Forced garbage collection for demonstration only.");

        await Task.CompletedTask;
    }
}
