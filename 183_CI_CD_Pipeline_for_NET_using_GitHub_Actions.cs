using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 183. CI/CD Pipeline for .NET using GitHub Actions
// Generated as a standalone sample file.
public class Problem183
{
    public static async Task Main()
    {
        Console.WriteLine("GitHub Actions CI/CD starter:");
        Console.WriteLine("name: dotnet-ci");
        Console.WriteLine("on: [push]");
        Console.WriteLine("steps: checkout -> setup-dotnet -> restore -> build -> test");

        await Task.CompletedTask;
    }
}
