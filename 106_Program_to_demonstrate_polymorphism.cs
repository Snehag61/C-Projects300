using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 106. Program to demonstrate polymorphism
// Generated as a standalone sample file.
public class Problem106
{
    public static async Task Main()
    {
        Shape[] shapes = [new Circle(), new Rectangle()];
        foreach (Shape shape in shapes) shape.Draw();

        await Task.CompletedTask;
    }
}

abstract class Shape { public abstract void Draw(); }
class Circle : Shape { public override void Draw() => Console.WriteLine("Drawing circle"); }
class Rectangle : Shape { public override void Draw() => Console.WriteLine("Drawing rectangle"); }