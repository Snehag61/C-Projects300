using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

// 69. Program to demonstrate StringBuilder
// Generated as a standalone sample file.
public class Problem069
{
    public static async Task Main()
    {
        StringBuilder builder = new();
        builder.Append("Hello");
        builder.Append(", ");
        builder.Append("StringBuilder");
        builder.Append('!');
        Console.WriteLine(builder.ToString());

        await Task.CompletedTask;
    }
}
