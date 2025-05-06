namespace Riverside.Hypervisor.Connections;

/// <summary>
/// Enumerates the possible states of a connection.
/// </summary>
public enum ConnectionState
{
	/// <summary>
	/// The connection is not established.
	/// </summary>
	Disconnected,
	/// <summary>
	/// The connection is in the process of being established.
	/// </summary>
	Connecting,
	/// <summary>
	/// The connection is established.
	/// </summary>
	Connected,
	/// <summary>
	/// The connection is in the process of disconnecting.
	/// </summary>
	Disconnecting,
	/// <summary>
	/// The connection has failed.
	/// </summary>
	Failed
}
