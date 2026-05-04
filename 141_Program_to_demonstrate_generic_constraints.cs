using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 141. Program to demonstrate generic constraints
// Generated as a standalone sample file.
public class Problem141
{
    public static async Task Main()
    {
        Repository<Student> repository = new();
        repository.Add(new Student { Name = "Sneha" });
        Console.WriteLine(repository.GetAll().First().Name);

        await Task.CompletedTask;
    }
}

interface IEntity { int Id { get; set; } }
class Student : IEntity { public int Id { get; set; } public string Name { get; set; } = ""; }
class Repository<T> where T : IEntity, new()
{
    private readonly List<T> _items = [];
    public void Add(T item) => _items.Add(item);
    public IReadOnlyList<T> GetAll() => _items;
}