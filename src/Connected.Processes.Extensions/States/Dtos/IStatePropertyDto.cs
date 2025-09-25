using Connected.Services;

namespace Connected.Processes.States.Dtos;
public interface IStatePropertyDto : IEntityDto
{
	List<IStateProperty> Items { get; set; }
}
