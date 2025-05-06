namespace Riverside.Hypervisor.Configuration;

/// <summary>
/// Represents the connection details used for an RDP session.
/// </summary>
public sealed class RdpConnectionDetails
{
	/// <summary>
	/// Gets or sets the server address for the RDP connection.
	/// </summary>
	public string ServerAddress { get; set; }

	/// <summary>
	/// Gets or sets the port number for the connection (default is usually 3389).
	/// </summary>
	public int Port { get; set; } = 3389;

	/// <summary>
	/// Gets or sets a value indicating whether Network Level Authentication (NLA) should be used.
	/// </summary>
	public bool UseNla { get; set; }
}
