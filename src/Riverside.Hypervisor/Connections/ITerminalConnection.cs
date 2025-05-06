namespace Riverside.Hypervisor.Connections;

/// <summary>
/// Represents a connection that provides a text-based terminal interface.
/// This is ideal for headless machines or for remote command execution.
/// </summary>
public interface ITerminalConnection : IConnection
{
	/// <summary>
	/// Asynchronously sends a command to the machine's terminal interface.
	/// The command is executed on the remote machine and its output is returned.
	/// </summary>
	/// <param name="command">The command text to execute.</param>
	/// <returns>
	/// A task representing the asynchronous operation. The task result contains the command output.
	/// </returns>
	Task<string> ExecuteCommandAsync(string command);

	/// <summary>
	/// Asynchronously reads from the terminal output stream.
	/// This method can be used for continuous output monitoring in interactive sessions.
	/// </summary>
	/// <returns>
	/// A task representing the asynchronous operation. The task result contains terminal output.
	/// </returns>
	Task<string> ReadOutputAsync();
}
