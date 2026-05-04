using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 98. Program to demonstrate value vs reference types
// Generated as a standalone sample file.
public class Problem098
{
    public static async Task Main()
    {
        int valueType = 10;
        int copiedValue = valueType;
        copiedValue = 20;
        
        Person original = new("Sneha");
        Person copiedReference = original;
        copiedReference.Name = "Updated";
        
        Console.WriteLine($"Value type original = {valueType}, copy = {copiedValue}");
        Console.WriteLine($"Reference type original = {original.Name}, copy = {copiedReference.Name}");

        await Task.CompletedTask;
    }
}

class Person(string name)
{
    public string Name { get; set; } = name;
}