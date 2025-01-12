using Connected.Processes.States.Dtos;

namespace Connected.Processes.Extensions.States;
public interface IStatePropertyProvider : IMiddleware
{
	Task Invoke(IStatePropertyDto dto);
}
