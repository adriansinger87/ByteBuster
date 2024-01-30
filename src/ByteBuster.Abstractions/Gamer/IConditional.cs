namespace ByteBuster.Abstractions.Gamer;

public interface IConditional
{
    uint PowerBank { get; }
    /// <summary>
    /// Gets the number of current energy points the player has.
    /// </summary>
    int PowerPoints { get; }
    
    /// <summary>
    /// Gets the velocity of of the player that defines how fast it can move
    /// </summary>
    uint Velocity { get; }

    /// <summary>
    /// Gets the status if the player is alive or not.
    /// </summary>
    bool IsAlive => PowerPoints > 0;

    void Charge(uint power);
    void Discharge(uint power);
    void UpgradePower(uint power);
}