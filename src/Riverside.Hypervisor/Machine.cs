namespace Riverside.Hypervisor;

/// <summary>
/// Provides a base implementation of <see cref="IMachine"/> that handles common functionality such as state management and event notification.
/// Concrete machine implementations (e.g. for RDP or Hyper-V) should derive from this class.
/// </summary>
public abstract class Machine : IMachine
{
	private MachineState _currentState = MachineState.Off;

	/// <inheritdoc />
	public string Id { get; protected set; }

	/// <inheritdoc />
	public virtual string DisplayName { get; set; }

	/// <inheritdoc />
	public virtual MachineState CurrentState
	{
		get => _currentState;
		protected set
		{
			if (_currentState != value)
			{
				var oldState = _currentState;
				_currentState = value;
				OnStateChanged(oldState, _currentState);
			}
		}
	}

	/// <inheritdoc />
	public virtual MachineCapabilities Capabilities { get; protected set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Machine"/> class.
	/// </summary>
	/// <param name="id">A unique identifier for the machine.</param>
	/// <param name="displayName">A human-friendly name for the machine.</param>
	/// <param name="capabilities">The capabilities that this machine supports.</param>
	protected Machine(string id, string displayName, MachineCapabilities capabilities)
	{
		Id = id;
		DisplayName = displayName;
		Capabilities = capabilities;
		CurrentState = MachineState.Off;
	}

	/// <inheritdoc />
	public abstract Task StartAsync();

	/// <inheritdoc />
	public abstract Task StopAsync();

	/// <inheritdoc />
	public abstract Task RestartAsync();

	/// <inheritdoc />
	public abstract Task ConnectAsync();

	/// <inheritdoc />
	public abstract Task DisconnectAsync();

	/// <inheritdoc />
	public abstract bool IsConnected { get; }

	/// <inheritdoc />
	public event EventHandler<MachineStateChangedEventArgs> StateChanged;

	/// <summary>
	/// Raises the <see cref="StateChanged"/> event.
	/// </summary>
	/// <param name="oldState">The state before the change.</param>
	/// <param name="newState">The state after the change.</param>
	protected virtual void OnStateChanged(MachineState oldState, MachineState newState)
	{
		StateChanged?.Invoke(this, new MachineStateChangedEventArgs(oldState, newState));
	}
}
