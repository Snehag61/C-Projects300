using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 34. Program to demonstrate break and continue
// Generated as a standalone sample file.
public class Problem034
{
    public static async Task Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 3) continue;
            if (i == 8) break;
            Console.WriteLine(i);
        }

        await Task.CompletedTask;
    }
}
