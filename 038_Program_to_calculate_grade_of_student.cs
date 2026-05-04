using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 38. Program to calculate grade of student
// Generated as a standalone sample file.
public class Problem038
{
    public static async Task Main()
    {
        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine() ?? "0");
        string grade = marks switch
        {
            >= 90 => "A+",
            >= 80 => "A",
            >= 70 => "B",
            >= 60 => "C",
            >= 50 => "D",
            _ => "F"
        };
        Console.WriteLine($"Grade = {grade}");

        await Task.CompletedTask;
    }
}
