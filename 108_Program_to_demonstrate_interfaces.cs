using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 108. Program to demonstrate interfaces
// Generated as a standalone sample file.
public class Problem108
{
    public static async Task Main()
    {
        IPrintable document = new Report();
        document.Print();

        await Task.CompletedTask;
    }
}

interface IPrintable { void Print(); }
class Report : IPrintable { public void Print() => Console.WriteLine("Printing report."); }