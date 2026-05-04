using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 156. File-based CRUD application
// Generated as a standalone sample file.
public class Problem156
{
    public static async Task Main()
    {
        Console.WriteLine("This starter focuses on the core flow of the requested console/business application.");
        Console.WriteLine("Review the domain classes below and extend the menu/actions as needed.");
        Sample.Run();

        await Task.CompletedTask;
    }
}

static class Sample
{
    public static void Run()
    {
        var items = new List<Record>
        {
            new() { Id = 1, Name = "Demo A", Value = "Active" },
            new() { Id = 2, Name = "Demo B", Value = "Pending" }
        };

        Console.WriteLine("Initial records:");
        foreach (var item in items)
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Value}");

        items.Add(new Record { Id = 3, Name = "Demo C", Value = "Created" });
        items[0].Value = "Updated";

        Console.WriteLine("\nAfter add/update:");
        foreach (var item in items)
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Value}");
    }
}
class Record
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Value { get; set; } = "";
}