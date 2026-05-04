using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 32. Program to demonstrate while loop
// Generated as a standalone sample file.
public class Problem032
{
    public static async Task Main()
    {
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine($"While loop iteration {i}");
            i++;
        }

        await Task.CompletedTask;
    }
}
