using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 47. Program to demonstrate tuples
// Generated as a standalone sample file.
public class Problem047
{
    public static async Task Main()
    {
        (int Id, string Name, double Score) student = (1, "Sneha", 95.5);
        Console.WriteLine($"{student.Id} - {student.Name} - {student.Score}");

        await Task.CompletedTask;
    }
}
