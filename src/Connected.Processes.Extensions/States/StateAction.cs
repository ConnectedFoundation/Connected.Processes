using Connected.Entities;

namespace Connected.Processes.States;
public record StateAction : Entity<string>, IStateAction
{
	public StateAction(string id, string name)
	{
		Id = id;
		Name = name;
	}
	public string Name { get; init; }
}
