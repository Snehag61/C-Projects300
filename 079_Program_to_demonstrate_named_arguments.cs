using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 79. Program to demonstrate named arguments
// Generated as a standalone sample file.
public class Problem079
{
    public static async Task Main()
    {
        Display(name: "Sneha", city: "Chennai", age: 21);
        
        static void Display(string name, int age, string city)
            => Console.WriteLine($"{name}, {age}, {city}");

        await Task.CompletedTask;
    }
}
