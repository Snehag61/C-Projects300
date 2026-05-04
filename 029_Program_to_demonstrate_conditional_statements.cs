using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 29. Program to demonstrate conditional statements
// Generated as a standalone sample file.
public class Problem029
{
    public static async Task Main()
    {
        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine() ?? "0");
        if (marks >= 90) Console.WriteLine("Excellent");
        else if (marks >= 75) Console.WriteLine("Very Good");
        else if (marks >= 60) Console.WriteLine("Good");
        else if (marks >= 40) Console.WriteLine("Pass");
        else Console.WriteLine("Fail");

        await Task.CompletedTask;
    }
}
