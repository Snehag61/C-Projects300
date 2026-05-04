using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 122. Program to demonstrate try-catch-finally
// Generated as a standalone sample file.
public class Problem122
{
    public static async Task Main()
    {
        try
        {
            int result = 10 / int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block always runs.");
        }

        await Task.CompletedTask;
    }
}
