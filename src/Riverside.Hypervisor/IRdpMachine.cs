using Riverside.Hypervisor.Configuration;

namespace Riverside.Hypervisor;

/// <summary>
/// Extends <see cref="IMachine"/> to include additional operations specific to Remote Desktop Protocol (RDP) sessions.
/// </summary>
public interface IRdpMachine : IMachine
{
	/// <summary>
	/// Gets the RDP connection details.
	/// </summary>
	RdpConnectionDetails ConnectionDetails { get; }

	/// <summary>
	/// Adjusts the resolution of the RDP session asynchronously.
	/// </summary>
	/// <param name="width">The desired width, in pixels.</param>
	/// <param name="height">The desired height, in pixels.</param>
	/// <returns>A task representing the asynchronous operation.</returns>
	Task ChangeResolutionAsync(int width, int height);

	/// <summary>
	/// Sends a key input (using virtual key codes) to the RDP session asynchronously.
	/// </summary>
	/// <param name="keyCode">The virtual key code for the key.</param>
	/// <returns>A task representing the asynchronous operation.</returns>
	Task SendKeyInputAsync(int keyCode);
}
