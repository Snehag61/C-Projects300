using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 163. Dependency Injection in Console App
// Generated as a standalone sample file.
public class Problem163
{
    public static async Task Main()
    {
        IMessageService service = new ConsoleMessageService();
        App app = new(service);
        app.Run();

        await Task.CompletedTask;
    }
}

interface IMessageService { void Send(string message); }
class ConsoleMessageService : IMessageService { public void Send(string message) => Console.WriteLine(message); }
class App(IMessageService service)
{
    public void Run() => service.Send("Dependency injection keeps the app loosely coupled.");
}