using ByteBuster;
using ByteBuster.Assets;
using ByteBuster.Gamer;
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

    [Fact]
    public void Player_PickUp_Assets()
    {
        var player = new Player();
        
        player.Condition.Discharge(5);
        player.PickUp(new RechargeAsset());
        player.PickUp(new PowerUpgradeAsset());
        player.PickUp(new KeyAsset());
        
        log.Trace(player.Condition);
        Assert.True(player.Condition.IsAlive); 
        Assert.True(player.Inventory.Count == 2);
        Assert.True(player.Condition.IsAlive);
    }
}