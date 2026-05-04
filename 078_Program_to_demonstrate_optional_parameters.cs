using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 78. Program to demonstrate optional parameters
// Generated as a standalone sample file.
public class Problem078
{
    public static async Task Main()
    {
        Greet("Sneha");
        Greet("Sneha", "Welcome back");
        
        static void Greet(string name, string message = "Hello")
            => Console.WriteLine($"{message}, {name}!");

        await Task.CompletedTask;
    }
}
