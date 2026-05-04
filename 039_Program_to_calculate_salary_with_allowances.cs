using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 39. Program to calculate salary with allowances
// Generated as a standalone sample file.
public class Problem039
{
    public static async Task Main()
    {
        Console.Write("Basic salary: ");
        double basic = double.Parse(Console.ReadLine() ?? "0");
        double hra = basic * 0.20;
        double da = basic * 0.10;
        double gross = basic + hra + da;
        Console.WriteLine($"HRA = {hra:F2}, DA = {da:F2}, Gross = {gross:F2}");

        await Task.CompletedTask;
    }
}
