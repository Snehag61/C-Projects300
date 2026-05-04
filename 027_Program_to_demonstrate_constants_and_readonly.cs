using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 27. Program to demonstrate constants and readonly
// Generated as a standalone sample file.
public class Problem027
{
    public static async Task Main()
    {
        Demo demo = new();
        Console.WriteLine($"Const value   : {Demo.PiLabel}");
        Console.WriteLine($"Readonly value: {demo.CreatedAt:yyyy-MM-dd HH:mm:ss}");

        await Task.CompletedTask;
    }
}

class Demo
{
    public const string PiLabel = "PI";
    public readonly DateTime CreatedAt = DateTime.Now;
}