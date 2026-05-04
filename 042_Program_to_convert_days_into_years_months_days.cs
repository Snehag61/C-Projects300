using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 42. Program to convert days into years, months, days
// Generated as a standalone sample file.
public class Problem042
{
    public static async Task Main()
    {
        Console.Write("Enter number of days: ");
        int days = int.Parse(Console.ReadLine() ?? "0");
        int years = days / 365;
        days %= 365;
        int months = days / 30;
        days %= 30;
        Console.WriteLine($"{years} years, {months} months, {days} days");

        await Task.CompletedTask;
    }
}
