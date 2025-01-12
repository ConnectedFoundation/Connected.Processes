using Connected.Services;

namespace Connected.Processes.States.Dtos;
public interface IStatePropertyDto : IDto
{
	long Activity { get; set; }
	List<IStateProperty> Items { get; set; }
}
