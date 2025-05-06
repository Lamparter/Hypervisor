namespace Riverside.Hypervisor.Connections;

/// <summary>
/// Provides data for changes in connection state.
/// </summary>
public sealed class ConnectionStateChangedEventArgs : EventArgs
{
	/// <summary>
	/// Gets the previous connection state.
	/// </summary>
	public ConnectionState OldState { get; }

	/// <summary>
	/// Gets the new connection state.
	/// </summary>
	public ConnectionState NewState { get; }

	/// <summary>
	/// Gets an optional message describing the state change.
	/// </summary>
	public string? Message { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ConnectionStateChangedEventArgs"/> class.
	/// </summary>
	/// <param name="oldState">The state before the change.</param>
	/// <param name="newState">The state after the change.</param>
	/// <param name="message">An optional message describing the change.</param>
	public ConnectionStateChangedEventArgs(ConnectionState oldState, ConnectionState newState, string? message = null)
	{
		OldState = oldState;
		NewState = newState;
		Message = message;
	}
}
