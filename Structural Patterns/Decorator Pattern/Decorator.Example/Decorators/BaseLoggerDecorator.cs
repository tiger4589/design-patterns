using Decorator.Example.Core;

namespace Decorator.Example.Decorators;

public abstract class BaseLoggerDecorator(ILogger logger) : ILogger
{
    public virtual async Task Log(string message)
    {
        await logger.Log(message);
    }
}