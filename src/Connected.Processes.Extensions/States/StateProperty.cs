using Connected.Entities;

namespace Connected.Processes.States;
public record StateProperty : Entity<string>, IStateProperty
{
	public StateProperty(string id, string value)
	{
		Id = id;
		Value = value;
	}

	public string Value { get; init; }
}
