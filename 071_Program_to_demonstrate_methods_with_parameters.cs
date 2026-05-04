using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 71. Program to demonstrate methods with parameters
// Generated as a standalone sample file.
public class Problem071
{
    public static async Task Main()
    {
        int Add(int a, int b) => a + b;
        Console.WriteLine($"Add(10, 20) = {Add(10, 20)}");

        await Task.CompletedTask;
    }
}
