using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Gamer;

namespace ByteBuster.Assets;

public class KeyAsset : IAsset
{
    public string Name { get; } = "Schlüssel";
    public string Description { get; } = "Öffnet eine Tür";
    public AssetUsageTypes UsageType => AssetUsageTypes.SingleUse;
}