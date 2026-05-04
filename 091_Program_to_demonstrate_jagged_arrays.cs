using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 91. Program to demonstrate jagged arrays
// Generated as a standalone sample file.
public class Problem091
{
    public static async Task Main()
    {
        int[][] jagged =
        [
            [1, 2],
            [3, 4, 5],
            [6]
        ];
        
        foreach (int[] row in jagged)
        {
            Console.WriteLine(string.Join(", ", row));
        }

        await Task.CompletedTask;
    }
}
