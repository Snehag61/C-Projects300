using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 125. Program to demonstrate collections (List)
// Generated as a standalone sample file.
public class Problem125
{
    public static async Task Main()
    {
        List<string> names = ["Sneha", "Ravi", "Anu"];
        names.Add("Kiran");
        foreach (string name in names) Console.WriteLine(name);

        await Task.CompletedTask;
    }
}
