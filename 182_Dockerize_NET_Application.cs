using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 182. Dockerize .NET Application
// Generated as a standalone sample file.
public class Problem182
{
    public static async Task Main()
    {
        Console.WriteLine("Docker starter:");
        Console.WriteLine("FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build");
        Console.WriteLine("WORKDIR /src");
        Console.WriteLine("RUN dotnet publish -c Release -o /app");
        Console.WriteLine("ENTRYPOINT [\"dotnet\", \"YourApp.dll\"]");

        await Task.CompletedTask;
    }
}
