using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

// 162. Configuration management using appsettings.json
// Generated as a standalone sample file.
public class Problem162
{
    public static async Task Main()
    {
        string json = "{\"AppSettings\":{\"ApplicationName\":\"DemoApp\",\"PageSize\":20}}";
        using JsonDocument document = JsonDocument.Parse(json);
        var appSettings = document.RootElement.GetProperty("AppSettings");
        Console.WriteLine(appSettings.GetProperty("ApplicationName").GetString());
        Console.WriteLine(appSettings.GetProperty("PageSize").GetInt32());

        await Task.CompletedTask;
    }
}
