using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Runtime;
using ByteBuster.Logging;
using ByteBuster.Logging.Extensions;
using Microsoft.Extensions.Logging;

namespace ByteBuster.Runtime;

public class PausedState : IRuntimeState
{
    private readonly ILogger log = LogFactoryProvider.CreateLogger<RunningState>();
    
    public RuntimeStateTypes StateType => RuntimeStateTypes.Paused;
    
    public void Start(IRuntime context)
    {
        // TODO: REALLY WANNA RESTART LEVEL?
        log.Debug("Do you want to restart the level?");
    }

    public void Stop(IRuntime context)
    {
        log.Debug("Stopping from Pause state.");
        context.SetState(new ReadyState());
    }

    public void Pause(IRuntime context)
    {
        log.Debug("Can't pause while in Pause state.");
    }

    public void Resume(IRuntime context)
    {
        log.Debug("Resuming from Pause state.");
        context.SetState(new RunningState());
    }
}