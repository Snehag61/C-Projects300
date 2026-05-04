using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 92. Program to demonstrate multidimensional arrays
// Generated as a standalone sample file.
public class Problem092
{
    public static async Task Main()
    {
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }

        await Task.CompletedTask;
    }
}
