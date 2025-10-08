using Connected.Entities;

namespace Connected.Processes.Design;
public interface IProcess : IEntity<int>
{
	string Code { get; init; }
	string Name { get; init; }
	string? Description { get; init; }
	Status Status { get; init; }
}
