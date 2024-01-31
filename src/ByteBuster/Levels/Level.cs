using System.Diagnostics;
using ByteBuster.Abstractions.Levels;

namespace ByteBuster.Levels;

public class Level(string name, ICell[,] map) : ILevel
{
    public string Name { get; } = name;
    public ICell[,] Map { get; private set; } = map;
}