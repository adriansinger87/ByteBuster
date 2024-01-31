using ByteBuster.Abstractions.Levels;
using ByteBuster.Assets;

namespace ByteBuster.Levels;

public class Cell(string key, CellData data) : ICell
{
    public string Key { get; } = key;
    public bool IsFree { get; } = data.IsFree;
    public string Foreground { get; } = data.Foreground;
    public string Background { get; } = data.Background;

    public override string ToString() => $"{Key} {(IsFree ? "free" : "blocked")}";
}