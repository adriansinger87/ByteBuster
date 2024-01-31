using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Runtime;
using ByteBuster.Logging;
using ByteBuster.Logging.Extensions;
using Microsoft.Extensions.Logging;

namespace ByteBuster.Runtime;

public class RunningState : IRuntimeState
{
    private readonly ILogger log = LogFactoryProvider.CreateLogger<RunningState>();
    
    public RuntimeStateTypes StateType => RuntimeStateTypes.Running;

    public void Start(IRuntime context)
    {
        log.Debug("Can't start while in running state.");
    }

    public void Stop(IRuntime context)
    {
        log.Debug("Stopping the runtime.");
        context.SetState(new ReadyState());
    }

    public void Pause(IRuntime context)
    {
        log.Debug("Pausing the runtime.");
        context.SetState(new PausedState());
    }

    public void Resume(IRuntime context)
    {
        log.Debug("Can't resume while in running state.");
    }
}