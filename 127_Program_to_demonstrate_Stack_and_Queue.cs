using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 127. Program to demonstrate Stack and Queue
// Generated as a standalone sample file.
public class Problem127
{
    public static async Task Main()
    {
        Stack<int> stack = new();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine($"Stack Pop: {stack.Pop()}");
        
        Queue<string> queue = new();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        Console.WriteLine($"Queue Dequeue: {queue.Dequeue()}");

        await Task.CompletedTask;
    }
}
