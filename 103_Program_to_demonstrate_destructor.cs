using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 103. Program to demonstrate destructor
// Generated as a standalone sample file.
public class Problem103
{
    public static async Task Main()
    {
        CreateAndRelease();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Destructor may run after GC.");
        
        static void CreateAndRelease()
        {
            Demo demo = new();
        }

        await Task.CompletedTask;
    }
}

class Demo
{
    ~Demo() => Console.WriteLine("Destructor called.");
}