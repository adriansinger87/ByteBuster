namespace ByteBuster.Levels;

public readonly struct CellData(string key, bool isFree, string background, string foreground)
{
    public string Key { get; init; } = key;
    public bool IsFree { get; init; } = isFree;
    public string Background { get; init; } = background;
    public string Foreground { get; init; } = foreground;
}