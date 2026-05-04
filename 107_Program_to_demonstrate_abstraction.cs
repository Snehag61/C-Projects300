using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 107. Program to demonstrate abstraction
// Generated as a standalone sample file.
public class Problem107
{
    public static async Task Main()
    {
        Vehicle vehicle = new Car();
        vehicle.Start();

        await Task.CompletedTask;
    }
}

abstract class Vehicle { public abstract void Start(); }
class Car : Vehicle { public override void Start() => Console.WriteLine("Car started."); }