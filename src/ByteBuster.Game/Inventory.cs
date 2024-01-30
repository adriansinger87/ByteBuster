using ByteBuster.Abstractions.Gamer;

namespace ByteBuster.Game;

public class Inventory : IInventory
{
    public List<IAsset> Assets { get; } = [];
}