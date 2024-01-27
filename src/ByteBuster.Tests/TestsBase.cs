using ByteBuster.Logging;
using ByteBuster.Tests.Extensions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace ByteBuster.Tests;

public abstract class TestsBase<T>
{
    protected ILogger log;

    protected TestsBase(ITestOutputHelper output)
    {
        LogFactoryProvider.Initialize(
            new LoggerFactory()
                .AddSerilogXUnit(output));
        log = LogFactoryProvider.CreateLogger<T>();
    }
}