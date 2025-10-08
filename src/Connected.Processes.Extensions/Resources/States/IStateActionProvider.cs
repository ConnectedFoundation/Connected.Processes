using Connected.Processes.States.Dtos;

namespace Connected.Processes.Extensions.States;
public interface IStateActionProvider : IMiddleware
{
	Task Invoke(IStateActionDto dto);
}
