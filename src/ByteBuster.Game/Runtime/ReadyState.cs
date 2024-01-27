using ByteBuster.Abstractions.Runtime;

namespace ByteBuster.Game.Runtime;

public class ReadyState : IRuntimeState
{
    public RuntimeStateTypes StateType => RuntimeStateTypes.Ready;

    public void Start(IRuntime context)
    {
        // IT RUNS
        context.SetState(new RunningState());
    }

    public void Stop(IRuntime context)
    {
        // nothing shall happen
    }

    public void Pause(IRuntime context)
    {
        // nothing shall happen
    }

    public void Resume(IRuntime context)
    {
        // nothing shall happen
    }
}