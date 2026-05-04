using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 35. Program to print pattern (stars)
// Generated as a standalone sample file.
public class Problem035
{
    public static async Task Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 1; i <= rows; i++)
        {
            Console.WriteLine(new string('*', i));
        }

        await Task.CompletedTask;
    }
}
