using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 58. Program to search an element in array
// Generated as a standalone sample file.
public class Problem058
{
    public static async Task Main()
    {
        int[] numbers = ReadIntArray();
        Console.Write("Search element: ");
        int target = int.Parse(Console.ReadLine() ?? "0");
        int index = Array.IndexOf(numbers, target);
        Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");
        
        static int[] ReadIntArray()
        {
            Console.Write("Enter numbers separated by spaces: ");
            return (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        await Task.CompletedTask;
    }
}
