namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Represents a data structure for mouse input events.
/// Instances of this class are used to send mouse activity (movement, clicks, etc.) to a remote machine.
/// </summary>
public struct MouseInput
{
	/// <summary>
	/// Gets or sets the X coordinate relative to the remote machine’s screen.
	/// </summary>
	public int X { get; set; }

	/// <summary>
	/// Gets or sets the Y coordinate relative to the remote machine’s screen.
	/// </summary>
	public int Y { get; set; }

	/// <summary>
	/// Gets or sets the mouse action to perform.
	/// </summary>
	public MouseAction Action { get; set; }
}
