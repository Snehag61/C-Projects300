using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 88. Program to validate password strength
// Generated as a standalone sample file.
public class Problem088
{
    public static async Task Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine() ?? "";
        bool strong =
            password.Length >= 8 &&
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit) &&
            password.Any(ch => !char.IsLetterOrDigit(ch));
        Console.WriteLine(strong ? "Strong password" : "Weak password");

        await Task.CompletedTask;
    }
}
