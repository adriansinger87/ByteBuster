using ByteBuster.Abstractions.Enumerations;

namespace ByteBuster.Abstractions.Runtime;

public interface IRuntimeState
{
    public RuntimeStateTypes StateType { get; }
    
    void Start(IRuntime context);
    void Stop(IRuntime context);
    void Pause(IRuntime context);
    void Resume(IRuntime context);
}