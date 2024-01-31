using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Runtime;
using ByteBuster.Runtime;
using ByteBuster.Logging.Extensions;
using Xunit.Abstractions;

namespace ByteBuster.Tests.Runtime;

public class GameRuntimeTests(ITestOutputHelper output) : TestsBase<GameRuntimeTests>(output)
{
    [Fact]
    public void Runtime_States_Shall_Rotate()
    {
        var runtime = new GameRuntime();
        log.Trace($"{typeof(GameRuntime)} constructor called.");
        
        Assert.True(runtime.StateType == RuntimeStateTypes.Ready);
        
        runtime.Start();
        Assert.True(runtime.StateType == RuntimeStateTypes.Running);
       
        runtime.Start();
        Assert.True(runtime.StateType == RuntimeStateTypes.Running);
       
        runtime.Pause();
        runtime.Start();
        Assert.True(runtime.StateType == RuntimeStateTypes.Paused);
        
        runtime.Resume();
        Assert.True(runtime.StateType == RuntimeStateTypes.Running);
        
        runtime.Stop();
        Assert.True(runtime.StateType == RuntimeStateTypes.Ready);
    }
}