using Connected.Processes.Extensions.States;
using Connected.Processes.States.Dtos;

namespace Connected.Processes.States;
public abstract class StateActionProvider : Middleware, IStateActionProvider
{
	protected IStateActionDto Dto { get; private set; } = default!;

	public async Task Invoke(IStateActionDto dto)
	{
		Dto = dto;

		await OnInvoke();
	}

	protected virtual async Task OnInvoke()
	{
		await Task.CompletedTask;
	}
}
