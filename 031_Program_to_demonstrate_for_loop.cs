using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 31. Program to demonstrate for loop
// Generated as a standalone sample file.
public class Problem031
{
    public static async Task Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"For loop iteration {i}");
        }

        await Task.CompletedTask;
    }
}
