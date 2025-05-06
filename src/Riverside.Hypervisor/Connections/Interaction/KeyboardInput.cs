namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Represents a data structure for keyboard input events.
/// Instances of this class are used to send keystrokes to a remote machine.
/// </summary>
public struct KeyboardInput
{
	/// <summary>
	/// Gets or sets the virtual key code corresponding to the key (e.g. 0x41 for 'A').
	/// </summary>
	public int VirtualKeyCode { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the key is pressed down.
	/// </summary>
	public bool KeyDown { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the key is an extended key (such as right-hand versions).
	/// </summary>
	public bool ExtendedKey { get; set; }
}
