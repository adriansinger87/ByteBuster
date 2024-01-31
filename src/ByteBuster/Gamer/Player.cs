using ByteBuster.Abstractions.Gamer;
using ByteBuster.Assets;
using ByteBuster.Logging;
using ByteBuster.Logging.Extensions;
using ByteBuster.Runtime;
using Microsoft.Extensions.Logging;

namespace ByteBuster.Gamer;

public class Player(string name) : IPlayer
{
    private readonly ILogger log = LogFactoryProvider.CreateLogger<RunningState>();
    public string Name {  get; private init; } = name;
    public IInventory Inventory { get; } = new Inventory();
    public IConditional Condition { get; } = new Conditions();

    public Player() : this("Player No. One") { }

    public void PickUp(IAsset asset)
    {
        log.Trace($"Picking up new asset '{asset}'.");
        ProcessAsset(asset);
    }

    // -- private helper
    
    private void ProcessAsset(IAsset asset)
    {
       if (ProcessKey(asset)) return;
       if (ProcessPowerUpgrade(asset)) return;
      
       ProcessRecharge(asset);
    }
    private bool ProcessKey(IAsset asset)
    {
        if (asset is not KeyAsset) return false;
        Inventory.Items.Add(asset);
        log.Debug($"Key '{asset}' added to inventory.");
        return true;
    }
    private bool ProcessPowerUpgrade(IAsset asset)
    {
        if (asset is not PowerUpgradeAsset) return false;
        Condition.UpgradePower(5);  // TODO: fix magic integer
        Inventory.Items.Add(asset);
        log.Debug($"New asset '{asset}' added to power bank.");
        return true;
    }
    private void ProcessRecharge(IAsset asset)
    {
        if (asset is not RechargeAsset) return;
        Condition.Charge(2);  // TODO: fix magic integer
        log.Debug($"Recharge '{asset}' picked up.");
    }
}