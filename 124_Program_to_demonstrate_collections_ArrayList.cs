using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

// 124. Program to demonstrate collections (ArrayList)
// Generated as a standalone sample file.
public class Problem124
{
    public static async Task Main()
    {
        ArrayList list = new() { 10, "C#", true, 45.5 };
        foreach (object item in list) Console.WriteLine(item);

        await Task.CompletedTask;
    }
}
