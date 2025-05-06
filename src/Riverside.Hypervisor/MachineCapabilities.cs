namespace Riverside.Hypervisor;

/// <summary>
/// Wraps a set of machine capabilities.
/// </summary>
public class MachineCapabilities
{
	/// <summary>
	/// Gets the underlying capability flags.
	/// </summary>
	public MachineCapability Capabilities { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MachineCapabilities"/> class with the specified capabilities.
	/// </summary>
	/// <param name="capabilities">A bitwise combination of <see cref="MachineCapability"/> values.</param>
	public MachineCapabilities(MachineCapability capabilities)
	{
		Capabilities = capabilities;
	}

	/// <summary>
	/// Determines whether the specified capability is supported.
	/// </summary>
	/// <param name="capability">The capability to test.</param>
	/// <returns>
	///   <c>true</c> if the machine supports the specified capability; otherwise, <c>false</c>.
	/// </returns>
	public bool Supports(MachineCapability capability)
	{
		return (Capabilities & capability) == capability;
	}
}
