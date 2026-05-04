using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 116. Program to demonstrate virtual and override
// Generated as a standalone sample file.
public class Problem116
{
    public static async Task Main()
    {
        Animal animal = new Cat();
        animal.Speak();

        await Task.CompletedTask;
    }
}

class Animal { public virtual void Speak() => Console.WriteLine("Animal sound"); }
class Cat : Animal { public override void Speak() => Console.WriteLine("Cat meows"); }