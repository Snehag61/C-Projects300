using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 97. Program to demonstrate Span and ReadOnlySpan
// Generated as a standalone sample file.
public class Problem097
{
    public static async Task Main()
    {
        int[] values = { 10, 20, 30, 40 };
        Span<int> span = values.AsSpan(1, 2);
        span[0] = 99;
        ReadOnlySpan<int> readOnly = values;
        Console.WriteLine(string.Join(", ", values));
        Console.WriteLine($"First via ReadOnlySpan = {readOnly[0]}");

        await Task.CompletedTask;
    }
}
