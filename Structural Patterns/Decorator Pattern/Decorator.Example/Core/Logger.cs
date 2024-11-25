using Decorator.Example.Models;

namespace Decorator.Example.Core;

public class Logger(LoggerConfiguration configuration) : ILogger
{
    public async Task Log(string message)
    {
        Console.WriteLine(message);
        await Task.CompletedTask;
    }
}