using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 44. Program to demonstrate var and dynamic
// Generated as a standalone sample file.
public class Problem044
{
    public static async Task Main()
    {
        var number = 10;
        dynamic anything = "Hello";
        Console.WriteLine($"var     -> {number.GetType().Name}: {number}");
        Console.WriteLine($"dynamic -> {anything.GetType().Name}: {anything}");
        anything = 12.5;
        Console.WriteLine($"dynamic changed -> {anything.GetType().Name}: {anything}");

        await Task.CompletedTask;
    }
}
