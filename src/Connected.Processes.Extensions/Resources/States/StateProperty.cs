using Connected.Entities;

namespace Connected.Processes.States;
public record StateProperty : Entity<string>, IStateProperty
{
	public StateProperty(string id, string text)
	{
		Id = id;
		Text = text;
	}

	public string Text { get; init; }
}
