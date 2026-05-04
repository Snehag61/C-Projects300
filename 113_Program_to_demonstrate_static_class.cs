using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 113. Program to demonstrate static class
// Generated as a standalone sample file.
public class Problem113
{
    public static async Task Main()
    {
        Console.WriteLine(Utility.Cube(3));

        await Task.CompletedTask;
    }
}

static class Utility
{
    public static int Cube(int value) => value * value * value;
}