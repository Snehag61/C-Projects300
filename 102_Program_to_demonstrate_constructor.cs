using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 102. Program to demonstrate constructor
// Generated as a standalone sample file.
public class Problem102
{
    public static async Task Main()
    {
        Student student = new(1, "Sneha");
        student.Display();

        await Task.CompletedTask;
    }
}

class Student(int id, string name)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public void Display() => Console.WriteLine($"{Id} - {Name}");
}