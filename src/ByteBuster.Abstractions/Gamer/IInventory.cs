namespace ByteBuster.Abstractions.Gamer;

public interface IInventory
{
    List<IAsset> Assets { get; }
}