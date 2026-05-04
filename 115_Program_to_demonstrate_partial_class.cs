using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 115. Program to demonstrate partial class
// Generated as a standalone sample file.
public class Problem115
{
    public static async Task Main()
    {
        Customer customer = new() { FirstName = "Sneha", LastName = "R" };
        Console.WriteLine(customer.FullName);

        await Task.CompletedTask;
    }
}

partial class Customer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
}
partial class Customer
{
    public string FullName => $"{FirstName} {LastName}";
}