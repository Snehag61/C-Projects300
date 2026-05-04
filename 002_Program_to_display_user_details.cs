using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 2. Program to display user details
// Generated as a standalone sample file.
public class Problem002
{
    public static async Task Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your city: ");
        string city = Console.ReadLine() ?? "";
        
        Console.WriteLine($"\nName: {name}");
        Console.WriteLine($"Age : {age}");
        Console.WriteLine($"City: {city}");

        await Task.CompletedTask;
    }
}
