namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Represents a full‑featured remote desktop connection.
/// This connection interface extends <see cref="IInteractiveConnection"/> by adding methods for
/// retrieving screen frames and changing the desktop resolution on the remote machine.
/// </summary>
public interface IRdpConnection : IInteractiveConnection
{
	/// <summary>
	/// Asynchronously retrieves a snapshot (screen frame) of the remote machine's desktop.
	/// The image data is typically returned in a compressed format (e.g., PNG).
	/// </summary>
	/// <returns>
	/// A task that represents the asynchronous operation. The task result contains the image data as a byte array.
	/// </returns>
	Task<byte[]> GetScreenFrameAsync();

	/// <summary>
	/// Asynchronously sets the screen resolution on the remote desktop.
	/// This can be used to change the display settings dynamically.
	/// </summary>
	/// <param name="width">The desired width in pixels.</param>
	/// <param name="height">The desired height in pixels.</param>
	/// <returns>A task representing the asynchronous operation.</returns>
	Task SetScreenResolutionAsync(int width, int height);
}
