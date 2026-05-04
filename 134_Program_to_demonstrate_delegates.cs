using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 134. Program to demonstrate delegates
// Generated as a standalone sample file.
public class Problem134
{
    public static async Task Main()
    {
        CalculatorDelegate operation = Add;
        Console.WriteLine(operation(10, 5));

        await Task.CompletedTask;
    }
}

delegate int CalculatorDelegate(int a, int b);
static int Add(int a, int b) => a + b;