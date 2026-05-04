using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 140. Program to demonstrate generics
// Generated as a standalone sample file.
public class Problem140
{
    public static async Task Main()
    {
        Box<int> intBox = new(100);
        Box<string> stringBox = new("Generic");
        Console.WriteLine(intBox.Value);
        Console.WriteLine(stringBox.Value);

        await Task.CompletedTask;
    }
}

class Box<T>(T value)
{
    public T Value { get; } = value;
}