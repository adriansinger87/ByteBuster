using ByteBuster.Abstractions.Enumerations;
using ByteBuster.Abstractions.Runtime;

namespace ByteBuster.Runtime;

public class GameRuntime : IRuntime
{
    public IRuntimeState State { get; private set; } = new ReadyState();
    public RuntimeStateTypes StateType => State.StateType;

    public void SetState(IRuntimeState newState)
    {
        State = newState;
    }

    public void Start()
    {
        State.Start(this);
    }

    public void Pause()
    {
        State.Pause(this);
    }

    public void Resume()
    {
        State.Resume(this);
    }

    public void Stop()
    {
        State.Stop(this);
    }
}