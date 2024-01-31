namespace ByteBuster.Abstractions.Gamer;

public interface IInventory
{
    List<IAsset> Items { get; }

    int Count { get; }
    
    
}