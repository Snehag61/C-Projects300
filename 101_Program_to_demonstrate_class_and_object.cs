using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 101. Program to demonstrate class and object
// Generated as a standalone sample file.
public class Problem101
{
    public static async Task Main()
    {
        Student student = new() { Id = 1, Name = "Sneha" };
        student.Display();

        await Task.CompletedTask;
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public void Display() => Console.WriteLine($"{Id} - {Name}");
}