using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 104. Program to demonstrate inheritance
// Generated as a standalone sample file.
public class Problem104
{
    public static async Task Main()
    {
        Dog dog = new();
        dog.Eat();
        dog.Bark();

        await Task.CompletedTask;
    }
}

class Animal { public void Eat() => Console.WriteLine("Animal eats."); }
class Dog : Animal { public void Bark() => Console.WriteLine("Dog barks."); }