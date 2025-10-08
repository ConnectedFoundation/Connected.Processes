using Connected.Processes.Extensions.States;
using Connected.Processes.States.Dtos;

namespace Connected.Processes.States;
public abstract class StatePropertyProvider : Middleware, IStatePropertyProvider
{
	protected IStatePropertyDto Dto { get; private set; } = default!;

	public async Task Invoke(IStatePropertyDto dto)
	{
		Dto = dto;

		await OnInvoke();
	}

	protected virtual async Task OnInvoke()
	{
		await Task.CompletedTask;
	}

}
