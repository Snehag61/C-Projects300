using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 33. Program to demonstrate do-while loop
// Generated as a standalone sample file.
public class Problem033
{
    public static async Task Main()
    {
        int i = 1;
        do
        {
            Console.WriteLine($"Do-while iteration {i}");
            i++;
        } while (i <= 5);

        await Task.CompletedTask;
    }
}
