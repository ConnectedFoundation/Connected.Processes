using Connected.Services;

namespace Connected.Processes.States.Dtos;
public interface IStateActionDto : IEntityDto
{
	List<IStateAction> Items { get; set; }
}
