using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 142. Program to demonstrate async and await
// Generated as a standalone sample file.
public class Problem142
{
    public static async Task Main()
    {
        await RunAsync();
        
        static async Task RunAsync()
        {
            Console.WriteLine("Starting...");
            await Task.Delay(500);
            Console.WriteLine("Completed.");
        }

        await Task.CompletedTask;
    }
}
