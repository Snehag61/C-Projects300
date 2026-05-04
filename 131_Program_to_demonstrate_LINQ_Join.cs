using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 131. Program to demonstrate LINQ (Join)
// Generated as a standalone sample file.
public class Problem131
{
    public static async Task Main()
    {
        var students = new[] { new { Id = 1, Name = "Sneha" }, new { Id = 2, Name = "Ravi" } };
        var marks = new[] { new { Id = 1, Score = 95 }, new { Id = 2, Score = 88 } };
        var query = students.Join(marks, s => s.Id, m => m.Id, (s, m) => new { s.Name, m.Score });
        foreach (var item in query) Console.WriteLine($"{item.Name} -> {item.Score}");

        await Task.CompletedTask;
    }
}
