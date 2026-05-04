using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 81. Program to demonstrate passing array to method
// Generated as a standalone sample file.
public class Problem081
{
    public static async Task Main()
    {
        int[] values = { 1, 2, 3, 4, 5 };
        Print(values);
        
        static void Print(int[] items)
        {
            foreach (int item in items) Console.WriteLine(item);
        }

        await Task.CompletedTask;
    }
}
