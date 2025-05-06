namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Provides an API for creating and managing connections to machines.
/// A typical Labware implementation might use this interface as a singleton
/// to track all active connections and to dynamically create new ones.
/// </summary>
public interface IConnectionManager
{
	/// <summary>
	/// Creates a new connection for the specified machine.
	/// The implementation should detect the machine type (or use configuration hints)
	/// and return an appropriate <see cref="IConnection"/> instance (such as an <see cref="IMachine"/>
	/// or an <see cref="ITerminalConnection"/>).
	/// </summary>
	/// <param name="machine">
	/// A reference to the machine (which implements <see cref="IMachine"/>) for which a connection is required.
	/// </param>
	/// <returns>An instance of <see cref="IConnection"/> for controlling and communicating with the specified machine.</returns>
	IConnection CreateConnection(IMachine machine);

	/// <summary>
	/// Gets the current set of active connections.
	/// </summary>
	IEnumerable<IConnection> ActiveConnections { get; }
}
