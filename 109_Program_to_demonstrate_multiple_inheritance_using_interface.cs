using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 109. Program to demonstrate multiple inheritance using interface
// Generated as a standalone sample file.
public class Problem109
{
    public static async Task Main()
    {
        SmartDevice device = new();
        device.Print();
        device.Scan();

        await Task.CompletedTask;
    }
}

interface IPrinter { void Print(); }
interface IScanner { void Scan(); }
class SmartDevice : IPrinter, IScanner
{
    public void Print() => Console.WriteLine("Printing...");
    public void Scan() => Console.WriteLine("Scanning...");
}