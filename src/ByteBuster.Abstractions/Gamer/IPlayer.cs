namespace ByteBuster.Abstractions.Gamer;

public interface IPlayer
{
    string Name { get; }
    
    IInventory Inventory { get; }
    
    IConditional Condition { get; }

    void PickUp(IAsset asset);
}