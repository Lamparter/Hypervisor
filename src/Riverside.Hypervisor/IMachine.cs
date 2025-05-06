namespace Riverside.Hypervisor;

/// <summary>
/// Represents the unified abstraction for a machine.
/// This interface unifies virtual machines, RDP sessions, and bare-metal servers.
/// </summary>
public interface IMachine
{
	/// <summary>
	/// Gets the unique identifier for the machine.
	/// </summary>
	string Id { get; }

	/// <summary>
	/// Gets or sets a human-friendly name for the machine.
	/// </summary>
	string DisplayName { get; set; }

	/// <summary>
	/// Gets the current operational state of the machine.
	/// </summary>
	MachineState CurrentState { get; }

	/// <summary>
	/// Gets the capabilities of the machine.
	/// </summary>
	MachineCapabilities Capabilities { get; }

	/// <summary>
	/// Powers on or starts the machine asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous start operation.</returns>
	Task StartAsync();

	/// <summary>
	/// Powers off or stops the machine asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous stop operation.</returns>
	Task StopAsync();

	/// <summary>
	/// Restarts the machine asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous restart operation.</returns>
	Task RestartAsync();

	/// <summary>
	/// Establishes a remote connection to the machine asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous connect operation.</returns>
	Task ConnectAsync();

	/// <summary>
	/// Terminates the remote connection to the machine asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous disconnect operation.</returns>
	Task DisconnectAsync();

	/// <summary>
	/// Gets a value indicating whether a remote connection to the machine is currently active.
	/// </summary>
	bool IsConnected { get; }

	/// <summary>
	/// Occurs when the machine's state changes.
	/// </summary>
	event EventHandler<MachineStateChangedEventArgs> StateChanged;
}
