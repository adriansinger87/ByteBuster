using ByteBuster.Levels;

namespace ByteBuster.Tests.Game;
using ByteBuster.Logging.Extensions;
using Xunit.Abstractions;

public class LevelTests(ITestOutputHelper output) : TestsBase<PlayerTests>(output) 
{
    [Fact]
    public void MapFactory_Build()
    {
        var factory = new MapFactory();
        var cells = factory
            .SetDimensions(3, 3)
            .PushKeys("~", "~", "~")
            .PushKeys("_", "_", ".")
            .PushKeys("X", "X", "X")
            .Build();

        var level = new Level("Level No. one", cells);
        
        Assert.True(!string.IsNullOrEmpty(level.Name));
        Assert.True(level.Map[0,0].IsBlocked);
        Assert.True(level.Map[1,2].HasForeground);
    }
}