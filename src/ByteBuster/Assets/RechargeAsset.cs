using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Gamer;

namespace ByteBuster.Assets;

public class RechargeAsset : IAsset
{
    public string Name { get; } = "Aufladung";
    public string Description { get; } = "Lädt den Spieler auf und gibt einmalig neue Energie";
    public AssetUsageTypes UsageType => AssetUsageTypes.SingleUse;

    public override string ToString() => $"{Name}";
}