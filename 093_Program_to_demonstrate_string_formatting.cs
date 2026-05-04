using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 93. Program to demonstrate string formatting
// Generated as a standalone sample file.
public class Problem093
{
    public static async Task Main()
    {
        double price = 1234.567;
        DateTime date = DateTime.Now;
        Console.WriteLine($"Currency : {price:C}");
        Console.WriteLine($"Number   : {price:N2}");
        Console.WriteLine($"Date     : {date:dd-MMM-yyyy}");

        await Task.CompletedTask;
    }
}
