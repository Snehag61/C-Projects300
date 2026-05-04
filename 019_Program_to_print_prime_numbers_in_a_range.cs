using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 19. Program to print prime numbers in a range
// Generated as a standalone sample file.
public class Problem019
{
    public static async Task Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine() ?? "0");
        
        bool IsPrime(int n) =>
            n > 1 && Enumerable.Range(2, (int)Math.Sqrt(n) - 1 < 0 ? 0 : (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
        
        var primes = Enumerable.Range(start, end - start + 1).Where(IsPrime);
        Console.WriteLine(string.Join(", ", primes));

        await Task.CompletedTask;
    }
}
