using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 195. Event-driven Architecture (Basic)
// Generated as a standalone sample file.
public class Problem195
{
    public static async Task Main()
    {
        EventBus bus = new();
        bus.Subscribe<OrderCreated>(e => Console.WriteLine($"Order event received for {e.OrderId}"));
        bus.Publish(new OrderCreated(101));

        await Task.CompletedTask;
    }
}

record OrderCreated(int OrderId);

class EventBus
{
    private readonly Dictionary<Type, List<Delegate>> _handlers = [];
    public void Subscribe<T>(Action<T> handler)
    {
        if (!_handlers.ContainsKey(typeof(T))) _handlers[typeof(T)] = [];
        _handlers[typeof(T)].Add(handler);
    }

    public void Publish<T>(T message)
    {
        if (!_handlers.TryGetValue(typeof(T), out var handlers)) return;
        foreach (var handler in handlers.Cast<Action<T>>()) handler(message);
    }
}