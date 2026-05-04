using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 50. Program to demonstrate DateTime class
// Generated as a standalone sample file.
public class Problem050
{
    public static async Task Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"Now       : {now}");
        Console.WriteLine($"Today     : {DateTime.Today:d}");
        Console.WriteLine($"Add 7 days: {now.AddDays(7):d}");
        Console.WriteLine($"Day of week: {now.DayOfWeek}");

        await Task.CompletedTask;
    }
}
