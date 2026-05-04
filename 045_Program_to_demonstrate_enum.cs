using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 45. Program to demonstrate enum
// Generated as a standalone sample file.
public class Problem045
{
    public static async Task Main()
    {
        Status status = Status.InProgress;
        Console.WriteLine($"Status = {status}, Value = {(int)status}");

        await Task.CompletedTask;
    }
}

enum Status { New = 1, InProgress = 2, Done = 3 }