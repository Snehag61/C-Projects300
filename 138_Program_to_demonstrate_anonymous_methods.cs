using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 138. Program to demonstrate anonymous methods
// Generated as a standalone sample file.
public class Problem138
{
    public static async Task Main()
    {
        Transformer transformer = delegate (string value)
        {
            return value.ToUpperInvariant();
        };
        
        Console.WriteLine(transformer("anonymous method"));

        await Task.CompletedTask;
    }
}

delegate string Transformer(string value);