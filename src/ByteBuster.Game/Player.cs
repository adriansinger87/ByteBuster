using ByteBuster.Abstractions;

namespace ByteBuster.Game;

public class Player(string name) : IPlayer
{
    public string Name {  get; private init; } = name;
    
    public Player() : this("Player No. One") { }
}