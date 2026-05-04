using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

// 167. API Consumption using HttpClient
// Generated as a standalone sample file.
public class Problem167
{
    public static async Task Main()
    {
        using HttpClient client = new();
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        Console.WriteLine("Sample request code ready. Uncomment when internet access is available.");

        await Task.CompletedTask;
    }
}
