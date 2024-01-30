using ByteBuster.Abstractions.Enumerations;

namespace ByteBuster.Abstractions.Gamer;

public interface IAsset
{
    string Name { get; }
    
    string Description  { get; }
    
    AssetUsageTypes UsageType { get; }
}