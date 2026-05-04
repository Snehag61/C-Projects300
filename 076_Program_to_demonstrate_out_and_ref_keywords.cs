using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 76. Program to demonstrate out and ref keywords
// Generated as a standalone sample file.
public class Problem076
{
    public static async Task Main()
    {
        int number = 10;
        Increment(ref number);
        SplitNumber(25, out int quotient, out int remainder);
        Console.WriteLine($"After ref increment: {number}");
        Console.WriteLine($"Out values: quotient={quotient}, remainder={remainder}");
        
        static void Increment(ref int value) => value++;
        static void SplitNumber(int value, out int q, out int r) { q = value / 2; r = value % 2; }

        await Task.CompletedTask;
    }
}
