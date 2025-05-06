namespace Riverside.Hypervisor.Connections;

/// <summary>
/// Extends IConnection to support health monitoring.
/// Implementations can use this interface to provide keep-alive and monitoring features.
/// </summary>
public interface IHealthCheckConnection : IConnection
{
	/// <summary>
	/// Asynchronously performs a health check on the connection.
	/// </summary>
	/// <returns><c>true</c> if the connection is healthy; otherwise, <c>false</c>.</returns>
	Task<bool> CheckHealthAsync();
}
