using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 57. Program to remove duplicate elements from array
// Generated as a standalone sample file.
public class Problem057
{
    public static async Task Main()
    {
        int[] numbers = ReadIntArray();
        Console.WriteLine(string.Join(", ", numbers.Distinct()));
        
        static int[] ReadIntArray()
        {
            Console.Write("Enter numbers separated by spaces: ");
            return (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        await Task.CompletedTask;
    }
}
