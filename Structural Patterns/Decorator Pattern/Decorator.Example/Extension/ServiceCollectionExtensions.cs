using Decorator.Example.Core;
using Decorator.Example.Decorators;
using Decorator.Example.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Decorator.Example.Extension;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLogger(this IServiceCollection services, LoggerConfiguration configuration)
    {
        services.AddSingleton<ILogger, Logger>((_) => new Logger(configuration));

        if (!string.IsNullOrWhiteSpace(configuration.DateFormat))
        {
            services.Decorate<ILogger>((inner) =>
                new TimestampLoggerDecorator(inner, configuration.DateFormat));
        }

        if (configuration.StackFrames != null)
        {
            services.Decorate<ILogger>((inner) =>
                new StackTraceLoggerDecorator(inner, configuration.StackFrames.Value));
        }

        return services;
    }
}