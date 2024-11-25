using Decorator.Example.Core;

namespace Decorator.Example.Decorators;

public class TimestampLoggerDecorator(ILogger logger, string dateFormat) : BaseLoggerDecorator(logger)
{
    public override async Task Log(string message)
    {
        message = $"[{DateTime.UtcNow.ToString(dateFormat)}] - {message}";
        await base.Log(message);
    }
}