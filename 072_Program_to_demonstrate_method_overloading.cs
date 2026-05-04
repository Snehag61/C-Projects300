using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 72. Program to demonstrate method overloading
// Generated as a standalone sample file.
public class Problem072
{
    public static async Task Main()
    {
        Console.WriteLine(Area(5));
        Console.WriteLine(Area(5, 10));
        
        static double Area(double radius) => Math.PI * radius * radius;
        static double Area(double length, double breadth) => length * breadth;

        await Task.CompletedTask;
    }
}
