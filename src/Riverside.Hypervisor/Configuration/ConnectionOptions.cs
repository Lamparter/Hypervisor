namespace Riverside.Hypervisor.Configuration;

/// <summary>
/// Provides configuration options for general machine connections.
/// </summary>
public sealed class ConnectionOptions
{
	/// <summary>
	/// Gets or sets the connection timeout in milliseconds.
	/// </summary>
	public int TimeoutMilliseconds { get; set; } = 30000;

	/// <summary>
	/// Gets or sets the number of retry attempts for a connection.
	/// </summary>
	public int MaxRetryAttempts { get; set; } = 3;
}
