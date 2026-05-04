using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 114. Program to demonstrate sealed class
// Generated as a standalone sample file.
public class Problem114
{
    public static async Task Main()
    {
        Child child = new();
        child.Display();

        await Task.CompletedTask;
    }
}

sealed class FinalClass
{
    public void Display() => Console.WriteLine("Sealed class prevents inheritance.");
}
class Child
{
    public void Display() => new FinalClass().Display();
}