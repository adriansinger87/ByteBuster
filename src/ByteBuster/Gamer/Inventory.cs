using ByteBuster.Abstractions.Gamer;

namespace ByteBuster.Gamer
{
    public class Inventory : IInventory
    { 
        public List<IAsset> Items { get; } = [];
        public int Count => Items.Count;

        [System.Runtime.CompilerServices.IndexerName("TheItem")]
        public IAsset this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }
    }
}