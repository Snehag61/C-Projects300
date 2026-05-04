using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;

// 150. Program to demonstrate performance optimization basics
// Generated as a standalone sample file.
public class Problem150
{
    public static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        string text = "";
        for (int i = 0; i < 5000; i++) text += i;
        sw.Stop();
        Console.WriteLine($"String concatenation: {sw.ElapsedMilliseconds} ms");
        
        sw.Restart();
        StringBuilder builder = new();
        for (int i = 0; i < 5000; i++) builder.Append(i);
        sw.Stop();
        Console.WriteLine($"StringBuilder       : {sw.ElapsedMilliseconds} ms");

        await Task.CompletedTask;
    }
}
