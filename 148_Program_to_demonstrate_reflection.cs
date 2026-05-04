using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 148. Program to demonstrate reflection
// Generated as a standalone sample file.
public class Problem148
{
    public static async Task Main()
    {
        Type type = typeof(Student);
        Console.WriteLine("Properties:");
        foreach (var property in type.GetProperties()) Console.WriteLine(property.Name);
        Console.WriteLine("Methods:");
        foreach (var method in type.GetMethods().Where(m => m.DeclaringType == type)) Console.WriteLine(method.Name);

        await Task.CompletedTask;
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public void Print() => Console.WriteLine(Name);
}