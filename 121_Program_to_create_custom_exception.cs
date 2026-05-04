using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 121. Program to create custom exception
// Generated as a standalone sample file.
public class Problem121
{
    public static async Task Main()
    {
        try
        {
            throw new InvalidMarksException("Marks cannot be greater than 100.");
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine(ex.Message);
        }

        await Task.CompletedTask;
    }
}

class InvalidMarksException(string message) : Exception(message);