using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 135. Program to demonstrate multicast delegates
// Generated as a standalone sample file.
public class Problem135
{
    public static async Task Main()
    {
        MessageHandler handlers = SayHello;
        handlers += SayWelcome;
        handlers("Sneha");
        
        static void SayWelcome(string name) => Console.WriteLine($"Welcome {name}");

        await Task.CompletedTask;
    }
}

delegate void MessageHandler(string name);
static void SayHello(string name) => Console.WriteLine($"Hello {name}");