using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 120. Program to demonstrate exception handling
// Generated as a standalone sample file.
public class Problem120
{
    public static async Task Main()
    {
        try
        {
            int value = int.Parse("not-a-number");
            Console.WriteLine(value);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Handled exception: {ex.Message}");
        }

        await Task.CompletedTask;
    }
}
