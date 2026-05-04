using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 43. Program to demonstrate nullable types
// Generated as a standalone sample file.
public class Problem043
{
    public static async Task Main()
    {
        int? age = null;
        Console.WriteLine(age.HasValue ? age.Value : 0);
        age = 24;
        Console.WriteLine(age ?? -1);

        await Task.CompletedTask;
    }
}
