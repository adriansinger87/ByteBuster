using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Gamer;

namespace ByteBuster.Game.Assets;

public class PowerUpgradeAsset : IAsset
{
    public string Name { get; } = "Power Bank";
    public string Description { get; } = "Erhöht permanent die Energiepunkte";
    public AssetUsageTypes UsageType => AssetUsageTypes.Permanent;
}