using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 89. Program to demonstrate regular expressions
// Generated as a standalone sample file.
public class Problem089
{
    public static async Task Main()
    {
        string sample = "Order 101, Item 55, Amount 7800";
        foreach (Match match in Regex.Matches(sample, @"\d+"))
        {
            Console.WriteLine(match.Value);
        }

        await Task.CompletedTask;
    }
}
