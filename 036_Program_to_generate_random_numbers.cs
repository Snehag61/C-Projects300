using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 36. Program to generate random numbers
// Generated as a standalone sample file.
public class Problem036
{
    public static async Task Main()
    {
        Random random = new();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(random.Next(1, 101));
        }

        await Task.CompletedTask;
    }
}
