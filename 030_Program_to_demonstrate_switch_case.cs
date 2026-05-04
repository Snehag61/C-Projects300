using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 30. Program to demonstrate switch-case
// Generated as a standalone sample file.
public class Problem030
{
    public static async Task Main()
    {
        Console.Write("Enter day number (1-7): ");
        int day = int.Parse(Console.ReadLine() ?? "0");
        string result = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        Console.WriteLine(result);

        await Task.CompletedTask;
    }
}
