using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

// 147. Program to demonstrate serialization (JSON)
// Generated as a standalone sample file.
public class Problem147
{
    public static async Task Main()
    {
        Student student = new() { Id = 1, Name = "Sneha" };
        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
        Student? restored = JsonSerializer.Deserialize<Student>(json);
        Console.WriteLine(restored?.Name);

        await Task.CompletedTask;
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}