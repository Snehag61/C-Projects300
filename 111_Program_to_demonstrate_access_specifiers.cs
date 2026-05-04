using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 111. Program to demonstrate access specifiers
// Generated as a standalone sample file.
public class Problem111
{
    public static async Task Main()
    {
        AccessDemo demo = new();
        Console.WriteLine(demo.PublicMessage);
        demo.ShowInternalState();

        await Task.CompletedTask;
    }
}

class AccessDemo
{
    public string PublicMessage = "Public member";
    private string PrivateMessage = "Private member";
    protected string ProtectedMessage = "Protected member";
    internal string InternalMessage = "Internal member";
    public void ShowInternalState() => Console.WriteLine($"{PrivateMessage}, {ProtectedMessage}, {InternalMessage}");
}