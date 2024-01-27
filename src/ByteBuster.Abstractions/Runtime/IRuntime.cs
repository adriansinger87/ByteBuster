namespace ByteBuster.Abstractions.Runtime;

public interface IRuntime
{
    IRuntimeState State { get; }
    
    RuntimeStateTypes StateType { get; }

    void SetState(IRuntimeState state);

    void Start();

    void Pause();

    void Resume();

    void Stop();
}