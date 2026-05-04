using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 105. Program to demonstrate method overriding
// Generated as a standalone sample file.
public class Problem105
{
    public static async Task Main()
    {
        Animal animal = new Dog();
        animal.Speak();

        await Task.CompletedTask;
    }
}

class Animal { public virtual void Speak() => Console.WriteLine("Animal sound"); }
class Dog : Animal { public override void Speak() => Console.WriteLine("Dog barks"); }