using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 146. Program to demonstrate file handling
// Generated as a standalone sample file.
public class Problem146
{
    public static async Task Main()
    {
        string path = Path.Combine(Path.GetTempPath(), "demo-file.txt");
        File.WriteAllText(path, "Hello from file handling.");
        Console.WriteLine(File.ReadAllText(path));
        Console.WriteLine(path);

        await Task.CompletedTask;
    }
}
