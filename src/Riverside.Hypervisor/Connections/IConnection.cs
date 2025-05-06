namespace Riverside.Hypervisor.Connections;

/// <summary>
/// Defines the basic functionality for a connection to a machine.
/// All connection types (graphical or terminal) must implement this interface.
/// </summary>
public interface IConnection : IDisposable
{
	/// <summary>
	/// Asynchronously establishes the connection to the machine.
	/// </summary>
	/// <returns>A task representing the connection operation.</returns>
	Task ConnectAsync();

	/// <summary>
	/// Asynchronously terminates the connection to the machine.
	/// </summary>
	/// <returns>A task representing the disconnection operation.</returns>
	Task DisconnectAsync();

	/// <summary>
	/// Gets the current state of the connection.
	/// </summary>
	ConnectionState State { get; }

	/// <summary>
	/// Occurs when the connection state changes.
	/// </summary>
	event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged;
}
