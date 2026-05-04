using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

// 188. Application Performance Monitoring
// Generated as a standalone sample file.
public class Problem188
{
    public static async Task Main()
    {
        ActivitySource source = new("Demo.Monitoring");
        using Activity? activity = source.StartActivity("LoadDashboard");
        Stopwatch sw = Stopwatch.StartNew();
        Thread.Sleep(100);
        sw.Stop();
        Console.WriteLine($"Operation took {sw.ElapsedMilliseconds} ms");

        await Task.CompletedTask;
    }
}
