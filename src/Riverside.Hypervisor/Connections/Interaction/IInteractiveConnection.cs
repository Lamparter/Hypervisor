namespace Riverside.Hypervisor.Connections.Interaction;

/// <summary>
/// Extends <see cref="IConnection"/> to provide interactive capabilities.
/// This interface is for connections that require sending user input (keyboard and mouse events).
/// </summary>
public interface IInteractiveConnection : IConnection
{
	/// <summary>
	/// Asynchronously sends a keyboard input event to the connected machine.
	/// </summary>
	/// <param name="input">The keyboard input data to send.</param>
	/// <returns>A task representing the asynchronous operation.</returns>
	Task SendKeyboardInputAsync(KeyboardInput input);

	/// <summary>
	/// Asynchronously sends a mouse input event to the connected machine.
	/// </summary>
	/// <param name="input">The mouse input data to send.</param>
	/// <returns>A task representing the asynchronous operation.</returns>
	Task SendMouseInputAsync(MouseInput input);
}
