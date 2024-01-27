using ByteBuster.Game;
using ByteBuster.Logging.Extensions;
using Xunit.Abstractions;

namespace ByteBuster.Tests.Game;

public class PlayerTests(ITestOutputHelper output) : TestsBase<PlayerTests>(output)
{
    [Fact]
    public void Player_Should_Initialize()
    {
        var player = new Player();
        log.Trace($"{typeof(Player)} constructor called.");
        
        Assert.NotNull(player);
        Assert.True(!string.IsNullOrEmpty(player.Name), "Player.Name should not be null or empty."); 
    }
}