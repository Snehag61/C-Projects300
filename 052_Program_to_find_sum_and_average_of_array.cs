using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 52. Program to find sum and average of array
// Generated as a standalone sample file.
public class Problem052
{
    public static async Task Main()
    {
        int[] numbers = ReadIntArray();
        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Average = {numbers.Average():F2}");
        
        static int[] ReadIntArray()
        {
            Console.Write("Enter numbers separated by spaces: ");
            return (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        await Task.CompletedTask;
    }
}
