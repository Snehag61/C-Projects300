using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 41. Program to check leap year
// Generated as a standalone sample file.
public class Problem041
{
    public static async Task Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine() ?? "0");
        bool isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        Console.WriteLine(isLeap ? "Leap year" : "Not a leap year");

        await Task.CompletedTask;
    }
}
