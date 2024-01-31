using ByteBuster.Abstractions.Gamer;
using ByteBuster.Logging;
using ByteBuster.Logging.Extensions;
using ByteBuster.Runtime;
using Microsoft.Extensions.Logging;

namespace ByteBuster.Gamer;

public class Conditions(uint power, uint velocity) : IConditional
{
    private readonly ILogger log = LogFactoryProvider.CreateLogger<RunningState>();
    public uint PowerBank { get; private set; } = power;
    public int PowerPoints { get; private set; } = (int)power;
    public uint Velocity { get; private set; } = velocity;
    
    public Conditions() : this(10, 10)
    {
        
    }
    
    public void Charge(uint power)
    {
        if (PowerPoints + power >= PowerBank)
        {
            PowerPoints = (int)PowerBank;
            return;
        }
        
        PowerPoints += (int)power;
        log.Debug($"Added {power} energy. Now {PowerPoints} points.");
    }
    public void Discharge(uint power)
    {
        if (PowerPoints - power < 0) return;
        
        PowerPoints -= (int)power;
        log.Debug($"Reduced {power} energy. Now {PowerPoints} points.");
    }
    public void UpgradePower(uint power)
    {
        PowerBank += power;
        log.Debug($"Power bank upgraded by {power} energy. Now {PowerBank} available.");
    }

    public override string ToString() => $"{PowerPoints} / {PowerBank} power bank, {Velocity} speed";
}