using Connected.Services;

namespace Connected.Processes.States.Dtos;
public interface IStateActionDto : IDto
{
	long Activity { get; set; }
	List<IStateAction> Items { get; set; }
}
