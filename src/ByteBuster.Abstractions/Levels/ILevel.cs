namespace ByteBuster.Abstractions.Levels;

public interface ILevel
{
    string Name { get; }
    public ICell[,] Map { get; }
}