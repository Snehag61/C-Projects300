using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 149. Program to demonstrate attributes
// Generated as a standalone sample file.
public class Problem149
{
    public static async Task Main()
    {
        var type = typeof(Student);
        var attribute = type.GetCustomAttributes(typeof(EntityAttribute), false).Cast<EntityAttribute>().FirstOrDefault();
        Console.WriteLine(attribute?.Name);
        
        [Entity("Student Entity")]

        await Task.CompletedTask;
    }
}

class Student { }
class EntityAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}