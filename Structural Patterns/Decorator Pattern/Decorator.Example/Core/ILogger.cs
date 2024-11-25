namespace Decorator.Example.Core;

public interface ILogger
{
    Task Log(string message);
}