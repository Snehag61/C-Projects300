using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 90. Program to demonstrate indexers
// Generated as a standalone sample file.
public class Problem090
{
    public static async Task Main()
    {
        Temperature weekly = new();
        weekly[0] = 31;
        weekly[1] = 33;
        weekly[2] = 29;
        Console.WriteLine($"Monday   : {weekly[0]}");
        Console.WriteLine($"Tuesday  : {weekly[1]}");
        Console.WriteLine($"Wednesday: {weekly[2]}");

        await Task.CompletedTask;
    }
}

class Temperature
{
    private readonly int[] _values = new int[7];
    public int this[int index]
    {
        get => _values[index];
        set => _values[index] = value;
    }
}