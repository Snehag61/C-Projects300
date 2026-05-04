using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 112. Program to demonstrate readonly vs const
// Generated as a standalone sample file.
public class Problem112
{
    public static async Task Main()
    {
        Demo demo = new();
        Console.WriteLine($"const = {Demo.MaxSize}");
        Console.WriteLine($"readonly = {demo.CreatedAt:HH:mm:ss}");

        await Task.CompletedTask;
    }
}

class Demo
{
    public const int MaxSize = 100;
    public readonly DateTime CreatedAt = DateTime.Now;
}