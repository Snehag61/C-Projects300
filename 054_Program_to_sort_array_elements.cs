using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 54. Program to sort array elements
// Generated as a standalone sample file.
public class Problem054
{
    public static async Task Main()
    {
        int[] numbers = ReadIntArray();
        Array.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers));
        
        static int[] ReadIntArray()
        {
            Console.Write("Enter numbers separated by spaces: ");
            return (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        await Task.CompletedTask;
    }
}
