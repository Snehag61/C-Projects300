using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 123. Program to demonstrate throwing exceptions
// Generated as a standalone sample file.
public class Problem123
{
    public static async Task Main()
    {
        try
        {
            ValidateAge(15);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        static void ValidateAge(int age)
        {
            if (age < 18) throw new ArgumentException("Age must be 18 or above.");
        }

        await Task.CompletedTask;
    }
}
