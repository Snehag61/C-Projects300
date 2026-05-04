using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 137. Program to demonstrate Func, Action, Predicate
// Generated as a standalone sample file.
public class Problem137
{
    public static async Task Main()
    {
        Func<int, int, int> multiply = (a, b) => a * b;
        Action<string> print = message => Console.WriteLine(message);
        Predicate<int> isEven = n => n % 2 == 0;
        
        print($"Multiply = {multiply(5, 6)}");
        print($"IsEven(10) = {isEven(10)}");

        await Task.CompletedTask;
    }
}
