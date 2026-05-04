using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 80. Program to demonstrate static methods
// Generated as a standalone sample file.
public class Problem080
{
    public static async Task Main()
    {
        Console.WriteLine($"Square = {MathUtility.Square(9)}");

        await Task.CompletedTask;
    }
}

static class MathUtility
{
    public static int Square(int value) => value * value;
}