using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 87. Program to validate email format
// Generated as a standalone sample file.
public class Problem087
{
    public static async Task Main()
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine() ?? "";
        bool valid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Console.WriteLine(valid ? "Valid email" : "Invalid email");

        await Task.CompletedTask;
    }
}
