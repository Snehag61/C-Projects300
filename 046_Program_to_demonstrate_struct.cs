using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 46. Program to demonstrate struct
// Generated as a standalone sample file.
public class Problem046
{
    public static async Task Main()
    {
        Point point = new(10, 20);
        Console.WriteLine(point);

        await Task.CompletedTask;
    }
}

readonly struct Point(int x, int y)
{
    public override string ToString() => $"({x}, {y})";
}