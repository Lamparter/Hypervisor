namespace Riverside.Hypervisor;

/// <summary>
/// Represents the various states a machine can be in.
/// </summary>
public enum MachineState
{
	/// <summary>
	/// The state is not determined.
	/// </summary>
	Unknown,
	/// <summary>
	/// The machine is currently powered off.
	/// </summary>
	Off,
	/// <summary>
	/// The machine is in the process of starting.
	/// </summary>
	Starting,
	/// <summary>
	/// The machine is currently running.
	/// </summary>
	Running,
	/// <summary>
	/// The machine is pausing or in the process of pausing.
	/// </summary>
	Pausing,
	/// <summary>
	/// The machine is paused.
	/// </summary>
	Paused,
	/// <summary>
	/// The machine is stopping or in the process of stopping.
	/// </summary>
	Stopping,
	/// <summary>
	/// The machine has encountered an error.
	/// </summary>
	Error
}
