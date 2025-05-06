namespace Riverside.Hypervisor;

/// <summary>
/// Provides data for machine state changes.
/// </summary>
public sealed class MachineStateChangedEventArgs : EventArgs
{
	/// <summary>
	/// Gets the state of the machine before the change.
	/// </summary>
	public MachineState OldState { get; private set; }

	/// <summary>
	/// Gets the state of the machine after the change.
	/// </summary>
	public MachineState NewState { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MachineStateChangedEventArgs"/> class.
	/// </summary>
	/// <param name="oldState">The previous state.</param>
	/// <param name="newState">The new state.</param>
	public MachineStateChangedEventArgs(MachineState oldState, MachineState newState)
	{
		OldState = oldState;
		NewState = newState;
	}
}
