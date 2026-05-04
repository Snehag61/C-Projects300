using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 61. Program to find transpose of matrix
// Generated as a standalone sample file.
public class Problem061
{
    public static async Task Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] transpose = new int[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                transpose[j, i] = matrix[i, j];
        PrintMatrix(transpose);
        
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        await Task.CompletedTask;
    }
}
