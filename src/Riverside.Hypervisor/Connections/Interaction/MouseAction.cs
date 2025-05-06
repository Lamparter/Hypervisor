namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Enumerates the various mouse actions supported by the connectivity system.
/// </summary>
public enum MouseAction
{
	/// <summary>
	/// Moves the mouse pointer.
	/// </summary>
	Move,
	/// <summary>
	/// Simulates a left mouse button click.
	/// </summary>
	LeftClick,
	/// <summary>
	/// Simulates a right mouse button click.
	/// </summary>
	RightClick,
	/// <summary>
	/// Simulates a middle mouse button click.
	/// </summary>
	MiddleClick,
	/// <summary>
	/// Simulates a double-click.
	/// </summary>
	DoubleClick,
	/// <summary>
	/// Simulates a scroll action.
	/// </summary>
	Scroll
}
