using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 53. Program to find largest and smallest element in array
// Generated as a standalone sample file.
public class Problem053
{
    public static async Task Main()
    {
        int[] numbers = ReadIntArray();
        Console.WriteLine($"Largest = {numbers.Max()}");
        Console.WriteLine($"Smallest = {numbers.Min()}");
        
        static int[] ReadIntArray()
        {
            Console.Write("Enter numbers separated by spaces: ");
            return (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        await Task.CompletedTask;
    }
}
