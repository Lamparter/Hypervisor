namespace Riverside.Hypervisor;

/// <summary>
/// Specifies the capabilities that a machine may support.
/// </summary>
[Flags]
public enum MachineCapability
{
	/// <summary>
	/// No capabilities.
	/// </summary>
	None = 0,
	/// <summary>
	/// Supports basic lifecycle control (start, stop, restart).
	/// </summary>
	LifecycleControl = 1,
	/// <summary>
	/// Supports remote connection access.
	/// </summary>
	RemoteAccess = 2,
	/// <summary>
	/// Supports taking snapshots.
	/// </summary>
	Snapshot = 4,
	/// <summary>
	/// Supports live migration between hosts.
	/// </summary>
	LiveMigration = 8
}
