namespace ByteBuster.Abstractions.Levels;

public interface ICell
{
    string Key { get; }
    bool IsFree { get; }
    bool HasForeground => !string.IsNullOrEmpty(Foreground);
    bool IsBlocked => !IsFree;
    string Foreground { get; }
    string Background { get; }
    
    
}