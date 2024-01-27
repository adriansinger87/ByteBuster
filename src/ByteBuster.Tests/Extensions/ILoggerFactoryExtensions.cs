using System.Text.Json;
using Microsoft.Extensions.Logging;
using Serilog;
using Xunit.Abstractions;

namespace ByteBuster.Tests.Extensions;

public static class ILoggerFactoryExtensions
{
    /// <summary>
    /// Adds the console sink to the logger factory.
    /// </summary>
    /// <param name="factory">The calling instance.</param>
    /// <param name="output">XUnit output</param>
    /// <returns>The calling instance.</returns>
    public static ILoggerFactory AddSerilogXUnit(this ILoggerFactory factory, ITestOutputHelper output)
    {
        factory.AddSerilog(
            GetConfig().WriteTo.TestOutput(output).CreateLogger());
        return factory;
    }
    
    private static LoggerConfiguration GetConfig()
    {
        var config = new LoggerConfiguration();
        config.MinimumLevel.Verbose();
        return config;
    }
}